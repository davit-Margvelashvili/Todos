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

        public MainForm(ITodoQueryService todoQueryService, ITodoCommandService todoCommandService)
        {
            InitializeComponent();

            _todoQueryService = todoQueryService;
            _todoCommandService = todoCommandService;
        }

        private void AddTodoButton_Click(object sender, EventArgs e)
        {
            var todoEditorForm = new TodoEditorForm();
            todoEditorForm.TodoCreated += TodoEditorForm_TodoCreatedAsync;
            todoEditorForm.ShowDialog();
        }

        private async void TodoEditorForm_TodoCreatedAsync(object sender, Todo newTodo)
        {
            _todos.Add(newTodo);
            await PopulateTodosAsync();

            if (sender is TodoEditorForm editorForm)
                editorForm.TodoCreated -= TodoEditorForm_TodoCreatedAsync;
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
            UserNameLabel.Text += e.Name;
        }

        private async Task LoadDataAsync()
        {
            _todos = await _todoQueryService.GetAllAsync();

            var todoBindingSource = new BindingSource { DataSource = _todos };

            TodoGrid.AutoGenerateColumns = false;
            TodoGrid.AutoSize = true;
            TodoGrid.DataSource = todoBindingSource;
            TodoGrid.CellValueChanged += TodoGrid_CellValueChanged;

            TodoGrid.Columns.Add(CreateComboBoxWithEnums<TodoStatus>("Status"));
            TodoGrid.Columns.Add(CreateComboBoxWithEnums<TodoPriority>("Priority"));

            await PopulateTodosAsync();
        }

        private void TodoGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var td = TodoGrid.Rows[e.RowIndex].DataBoundItem as Todo;
        }

        private DataGridViewComboBoxColumn CreateComboBoxWithEnums<TEnum>(string propertyName) =>
            new DataGridViewComboBoxColumn
            {
                DataSource = Enum.GetValues(typeof(TEnum)),
                DataPropertyName = propertyName,
                Name = propertyName
            };

        private async Task PopulateTodosAsync()
        {
            var users = await ServiceContainer.Get<IUserQueryService>().GetAllAsync();
            users.Insert(0, User.Empty);
            var todoItemControls = _todos.Select(todo => new TodoItemControl(todo, users, OnTodoUpdate)).ToArray();

            TodoListView.Controls.AddRange(todoItemControls);
        }

        private async void OnTodoUpdate(object sender, Todo todo)
        {
            await _todoCommandService.EditAsync(todo);
        }
    }
}