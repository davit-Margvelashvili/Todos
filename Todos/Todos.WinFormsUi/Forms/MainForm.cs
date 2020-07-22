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
            PopulateTodos();

            if (sender is TodoEditorForm editorForm)
                editorForm.TodoCreated -= TodoEditorForm_TodoCreated;
        }

        private async void MainForm_LoadAsync(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            _todos = await _todoQueryService.GetAllAsync();
            PopulateTodos();
        }

        private void PopulateTodos()
        {
            var todoItemControls = _todos.Select(todo => new TodoItemControl(todo, OnTodoUpdate)).ToArray();

            TodoListView.Controls.AddRange(todoItemControls);
        }

        private async void OnTodoUpdate(object sender, Todo todo)
        {
            await _todoCommandService.EditAsync(todo);
        }
    }
}