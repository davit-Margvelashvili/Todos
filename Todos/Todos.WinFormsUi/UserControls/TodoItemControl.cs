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
using Todos.Core.Utils;

namespace Todos.WinFormsUi.UserControls
{
    public partial class TodoItemControl : UserControl
    {
        private bool _pendingChanges = false;

        public bool PendingChanges
        {
            get => _pendingChanges;
            set
            {
                _pendingChanges = value;
                SaveChangesButton.Visible = _pendingChanges;
                DiscardChangesButton.Visible = _pendingChanges;
            }
        }

        private readonly Todo _todo;
        private readonly Todo _originalTodo;
        private readonly string[] _priorityCollection;
        private readonly string[] _statusCollection;

        public event EventHandler<Todo> TodoUpdated;

        public TodoItemControl(Todo todo, EventHandler<Todo> todoUpdateCallback = null)
        {
            _todo = todo;
            _originalTodo = todo.DeepCopy();

            InitializeComponent();

            _statusCollection = Enum.GetNames(typeof(TodoStatus));
            _priorityCollection = Enum.GetNames(typeof(TodoPriority));

            StatusBox.DataSource = _statusCollection;
            PriorityBox.DataSource = _priorityCollection;

            PopulateData(_originalTodo);

            if (todoUpdateCallback != null)
                TodoUpdated += todoUpdateCallback;

            PendingChanges = false;
        }

        private void PopulateData(Todo todo)
        {
            TitleTextBox.Text = todo.Title;
            DescriptionTextBox.Text = todo.Description;
            StartDatePicker.Value = todo.StartDate;
            DueDatePicker.Value = todo.DueDate;
            StatusBox.SelectedIndex = _statusCollection.IndexOf(todo.Status.ToString());
            PriorityBox.SelectedIndex = _priorityCollection.IndexOf(todo.Priority.ToString());
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _todo.Title = TitleTextBox.Text;
            PendingChanges = true;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            _todo.Description = DescriptionTextBox.Text;
            PendingChanges = true;
        }

        private void UserBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserBox.SelectedItem is User selectedUser)
            {
                _todo.UserId = selectedUser.Id;
                PendingChanges = true;
            }
        }

        private void StatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _todo.Status = StatusBox.SelectedItem.ToString().ParseEnum<TodoStatus>();
            PendingChanges = true;
        }

        private void PriorityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _todo.Priority = PriorityBox.SelectedItem.ToString().ParseEnum<TodoPriority>();
            PendingChanges = true;
        }

        private void StartDatePicker_ValueChanged(object sender, EventArgs e)
        {
            _todo.StartDate = StartDatePicker.Value;
            PendingChanges = true;
        }

        private void DueDatePicker_ValueChanged(object sender, EventArgs e)
        {
            _todo.DueDate = DueDatePicker.Value;
            PendingChanges = true;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            TodoUpdated?.Invoke(this, _todo);
            PendingChanges = false;
        }

        private void DiscardChangesButton_Click(object sender, EventArgs e)
        {
            PopulateData(_originalTodo);

            _todo.Title = _originalTodo.Title;
            _todo.Description = _originalTodo.Description;
            _todo.Status = _originalTodo.Status;
            _todo.Priority = _originalTodo.Priority;
            _todo.StartDate = _originalTodo.StartDate;
            _todo.DueDate = _originalTodo.DueDate;
            _todo.UserId = _originalTodo.UserId;
            PendingChanges = false;
        }
    }
}