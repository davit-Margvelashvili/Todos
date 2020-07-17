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
        private readonly ITodoCommandService _todoCommandService;
        private readonly ITodoQueryService _todoQueryService;

        private List<Todo> _todos;

        public MainForm(ITodoCommandService todoCommandService, ITodoQueryService todoQueryService)
        {
            InitializeComponent();

            _todoCommandService = todoCommandService;
            _todoQueryService = todoQueryService;
        }

        private async void AddTodoButton_ClickAsync(object sender, EventArgs e)
        {
            AddTodoButton.Enabled = false;
            var newTodo = new Todo
            {
                Title = TitleTextBox.Text,
                Description = DescriptionTextBox.Text,
                StartDate = StartDatePicker.Value,
                DueDate = DueDatePicker.Value
            };
            await _todoCommandService.AddAsync(newTodo);
            _todos.Add(newTodo);
            PopulateTodos();

            AddTodoButton.Enabled = true;
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