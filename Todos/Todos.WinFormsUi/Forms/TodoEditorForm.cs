using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todos.Core.Abstractions;
using Todos.Core.Models;

namespace Todos.WinFormsUi.Forms
{
    public partial class TodoEditorForm : Form
    {
        private readonly ITodoCommandService _todoCommandService;

        public event EventHandler<Todo> TodoCreated;

        public TodoEditorForm()
        {
            _todoCommandService = ServiceContainer.Get<ITodoCommandService>();
            InitializeComponent();
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
            var result = await _todoCommandService.AddAsync(newTodo);

            TodoCreated?.Invoke(this, result);

            AddTodoButton.Enabled = true;
        }
    }
}