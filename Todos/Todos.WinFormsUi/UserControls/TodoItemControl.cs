using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private readonly List<User> _user;
        private readonly Todo _originalTodo;

        public event EventHandler<Todo> TodoUpdated;

        public TodoItemControl(Todo todo, List<User> user, EventHandler<Todo> todoUpdateCallback = null)
        {
            _todo = todo;

            _user = user;
            _originalTodo = todo.DeepCopy();

            InitializeComponent();

            BindData();

            if (todoUpdateCallback != null)
                TodoUpdated += todoUpdateCallback;
        }

        private void BindData()
        {
            TitleTextBox.DataBindings.Add("Text", _todo, nameof(Todo.Title));
            DescriptionTextBox.DataBindings.Add("Text", _todo, nameof(Todo.Description));

            StartDatePicker.DataBindings.Add("Value", _todo, nameof(Todo.StartDate));
            DueDatePicker.DataBindings.Add("Value", _todo, nameof(Todo.DueDate));

            StatusBox.DataBindings.Add(nameof(ComboBox.SelectedItem), _todo, nameof(_todo.Status));
            StatusBox.DataSource = Enum.GetValues(typeof(TodoStatus));

            PriorityBox.DataBindings.Add(nameof(ComboBox.SelectedItem), _todo, nameof(_todo.Priority));
            PriorityBox.DataSource = Enum.GetValues(typeof(TodoPriority));

            UserBox.DisplayMember = nameof(User.Name);
            UserBox.DataSource = _user;

            UserBox.DataBindings.Add(nameof(ComboBox.SelectedItem), _todo, nameof(Todo.AssignedTo));
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            PendingChanges = true;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (_todo.AssignedTo == User.Empty)
            {
                _todo.AssignedTo = null;
                _todo.UserId = null;
            }
            TodoUpdated?.Invoke(this, _todo);

            PendingChanges = false;
        }

        private void DiscardChangesButton_Click(object sender, EventArgs e)
        {
            _todo.Title = _originalTodo.Title;
            _todo.Description = _originalTodo.Description;
            _todo.Status = _originalTodo.Status;
            _todo.Priority = _originalTodo.Priority;
            _todo.StartDate = _originalTodo.StartDate;
            _todo.DueDate = _originalTodo.DueDate;
            _todo.UserId = _originalTodo.UserId;
            _todo.AssignedTo = _originalTodo.AssignedTo;
            PendingChanges = false;
        }

        private void TodoItemControl_Load(object sender, EventArgs e)
        {
            PendingChanges = false;
        }
    }
}