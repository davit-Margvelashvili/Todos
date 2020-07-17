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

namespace Todos.WinFormsUi
{
    public partial class MainForm : Form
    {
        private readonly ITodoCommandService _todoCommandService;

        public MainForm(ITodoCommandService todoCommandService)
        {
            _todoCommandService = todoCommandService;
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
            await _todoCommandService.AddAsync(newTodo);
            AddTodoButton.Enabled = true;

            //MessageBox.Show("Todo Added");
        }
    }
}