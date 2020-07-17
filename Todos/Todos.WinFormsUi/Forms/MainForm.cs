using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todos.Core.Abstractions;
using Todos.Core.Models;

namespace Todos.WinFormsUi.Forms
{
    public partial class MainForm : Form
    {
        private readonly ITodoQueryService _todoQueryService;

        private List<Todo> _todos;

        public MainForm(ITodoQueryService todoQueryService)
        {
            InitializeComponent();

            _todoQueryService = todoQueryService;
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
            TodoListBox.Items.Clear();
            TodoListBox.Items.AddRange(_todos.Select(todo => $"{todo.Title} {todo.Status}").ToArray());
        }
    }
}