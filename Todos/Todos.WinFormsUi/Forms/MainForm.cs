using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todos.Core.Abstractions;
using Todos.Core.Models;
using Todos.WinFormsUi.UserControls;

namespace Todos.WinFormsUi.Forms
{
    public partial class MainForm : Form
    {
        private readonly ITodoQueryService _todoQueryService;
        private readonly ITodoCommandService _todoCommandService;

        private List<Todo> _todos;
        private List<User> _users;

        private readonly HashSet<int> _changedRows = new HashSet<int>();

        public MainForm(ITodoQueryService todoQueryService, ITodoCommandService todoCommandService)
        {
            InitializeComponent();

            _todoQueryService = todoQueryService;
            _todoCommandService = todoCommandService;
        }

        private void AddTodoButton_Click(object sender, EventArgs e)
        {
            var todoEditorForm = new TodoEditorForm();
            todoEditorForm.TodoCreated += TodoEditorForm_TodoCreated;
            todoEditorForm.ShowDialog();
        }

        private async void TodoEditorForm_TodoCreated(object sender, Todo newTodo)
        {
            _todos.Add(newTodo);

            if (sender is TodoEditorForm editorForm)
                editorForm.TodoCreated -= TodoEditorForm_TodoCreated;
        }

        private async void MainForm_LoadAsync(object sender, EventArgs e)
        {
            //var loginForm = new LoginForm();
            //loginForm.Success += OnSuccessfulLogin;
            //if (loginForm.ShowDialog() != DialogResult.OK)
            //    Application.Exit();

            await LoadDataAsync();
        }

        private void OnSuccessfulLogin(object sender, User e)
        {
        }

        private async Task LoadDataAsync()
        {
            _todos = await _todoQueryService.GetAllAsync();
            _users = await ServiceContainer.Get<IUserQueryService>().GetAllAsync();
            _users.Insert(0, User.Empty);

            TodoGrid.AutoGenerateColumns = false;

            TodoGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = nameof(Todo.Title),
                Name = "Title"
            });

            TodoGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = nameof(Todo.Description),
                Name = "Description"
            });

            TodoGrid.Columns.Add(new DataGridViewComboBoxColumn()
            {
                DataSource = Enum.GetValues(typeof(TodoStatus)),
                DataPropertyName = nameof(Todo.Status),
                Name = "Status"
            });

            TodoGrid.Columns.Add(new DataGridViewComboBoxColumn()
            {
                DataSource = Enum.GetValues(typeof(TodoPriority)),
                DataPropertyName = nameof(Todo.Priority),
                Name = "Priority"
            });

            TodoGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = nameof(Todo.StartDate),
                Name = "Start Date"
            });

            TodoGrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = nameof(Todo.DueDate),
                Name = "Due Date"
            });

            TodoGrid.DataSource = _todos;
        }

        private async void OnTodoUpdateAsync(object sender, Todo todo)
        {
            await _todoCommandService.EditAsync(todo);
        }

        private void TodoGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            _changedRows.Add(e.RowIndex);
        }

        private async void SaveChangesButton_ClickAsync(object sender, EventArgs e)
        {
            var changedTodos = _changedRows.Select(i => TodoGrid.Rows[i].DataBoundItem as Todo).ToList();
            var changes = await _todoCommandService.UpdateAsync(changedTodos);

            MessageBox.Show($"{changes} todos updated", "Successfully Updated");
        }
    }
}