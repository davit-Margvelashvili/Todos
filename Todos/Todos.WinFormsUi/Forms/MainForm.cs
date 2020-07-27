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
            todoEditorForm.TodoCreated += TodoEditorForm_TodoCreated;
            todoEditorForm.ShowDialog();
        }

        private void TodoEditorForm_TodoCreated(object sender, Todo newTodo)
        {
            _todos.Add(newTodo);
            PopulateTodosAsync();

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
            UserNameLabel.Text += e.Name;
        }

        private async Task LoadDataAsync()
        {
            _todos = await _todoQueryService.GetAllAsync();
            await PopulateTodosAsync();
        }

        private async Task PopulateTodosAsync()
        {
            var users = await ServiceContainer.Get<IUserQueryService>().GetAllAsync();
            users.Insert(0, User.Empty);
            var todoItemControls = _todos.Select(todo => new TodoItemControl(todo, users, OnTodoUpdateAsync)).ToArray();

            TodoListView.Controls.AddRange(todoItemControls);
        }

        private async void OnTodoUpdateAsync(object sender, Todo todo)
        {
            await _todoCommandService.EditAsync(todo);
        }
    }
}