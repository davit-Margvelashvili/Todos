using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Todos.Core.Models;

namespace Todos.WinFormsUi.UserControls
{
    public partial class TodoItemControl : UserControl
    {
        private readonly Todo _todo;
        private string[] statusCollection;
        private string[] priorityCollection;

        public TodoItemControl(Todo todo)
        {
            InitializeComponent();

            statusCollection = Enum.GetNames(typeof(TodoStatus));
            priorityCollection = Enum.GetNames(typeof(TodoPriority));

            StatusBox.DataSource = statusCollection;
            PriorityBox.DataSource = priorityCollection;

            _todo = todo;
            TitleTextBox.Text = todo.Title;
            DescriptionTextBox.Text = todo.Description;
            StartDatePicker.Value = todo.StartDate;
            DueDatePicker.Value = todo.DueDate;
            StatusBox.SelectedIndex = statusCollection.IndexOf(todo.Status.ToString());
            PriorityBox.SelectedIndex = priorityCollection.IndexOf(todo.Priority.ToString());
        }
    }
}