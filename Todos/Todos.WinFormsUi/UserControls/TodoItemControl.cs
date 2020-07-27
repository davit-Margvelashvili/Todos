using System;
using System.CodeDom;
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
using Todos.Core.Abstractions;
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
        private List<User> _users;
        private readonly Todo _originalTodo;

        public event EventHandler<Todo> TodoUpdated;

        public TodoItemControl(Todo todo, List<User> users, EventHandler<Todo> todoUpdateCallback = null)
        {
            _todo = todo;
            _users = users;
            _originalTodo = todo.DeepCopy();

            InitializeComponent();

            if (todoUpdateCallback != null)
                TodoUpdated += todoUpdateCallback;
        }

        private void BindData()
        {
            UserBox.ValueMember = nameof(User.Id);
            UserBox.DisplayMember = nameof(User.Name);

            UserBox.DataBindings.Add("SelectedItem", _todo, nameof(_todo.AssignedTo), false, DataSourceUpdateMode.Never);
            //UserBox.DataBindings.Add("SelectedValue", _todo, nameof(_todo.UserId), false, DataSourceUpdateMode.OnPropertyChanged);
            UserBox.DataSource = _users.ToList();

            StatusBox.DataSource = (TodoStatus[])Enum.GetValues(typeof(TodoStatus));
            StatusBox.DataBindings.Add(nameof(StatusBox.SelectedItem), _todo, nameof(_todo.Status));

            PriorityBox.DataSource = (TodoPriority[])Enum.GetValues(typeof(TodoPriority));
            PriorityBox.DataBindings.Add(nameof(StatusBox.SelectedItem), _todo, nameof(_todo.Priority));

            TitleTextBox.DataBindings.Add("Text", _todo, nameof(_todo.Title));
            DescriptionTextBox.DataBindings.Add("Text", _todo, nameof(_todo.Description));
            StartDatePicker.DataBindings.Add("Value", _todo, nameof(_todo.StartDate));
            DueDatePicker.DataBindings.Add("Value", _todo, nameof(_todo.DueDate));
        }

        private void ValueChanged(object sender, EventArgs e)
        {
            PendingChanges = true;
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            if (UserBox.SelectedItem == User.Empty)
            {
                _todo.UserId = null;
                _todo.AssignedTo = null;
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
            PendingChanges = false;
        }

        private async void TodoItemControl_Load(object sender, EventArgs e)
        {
            _users = await ServiceContainer.Get<IUserQueryService>().GetAllAsync();
            BindData();

            PendingChanges = false;
        }
    }
}