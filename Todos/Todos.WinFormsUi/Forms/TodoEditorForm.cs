using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Identity.Client;
using Todos.Core.Abstractions;
using Todos.Core.Models;
using Todos.Core.Utils;

namespace Todos.WinFormsUi.Forms
{
    public partial class TodoEditorForm : Form
    {
        private readonly ITodoCommandService _todoCommandService;
        private readonly IUserQueryService _userQueryService;
        private readonly IDateTimeProvider _dateTimeProvider;

        private List<User> _users;
        private bool _pendingChanges;

        public event EventHandler<Todo> TodoCreated;

        public TodoEditorForm()
        {
            InitializeComponent();

            _todoCommandService = ServiceContainer.Get<ITodoCommandService>();
            _userQueryService = ServiceContainer.Get<IUserQueryService>();
            _dateTimeProvider = ServiceContainer.Get<IDateTimeProvider>();

            StatusBox.DataSource = Enum.GetNames(typeof(TodoStatus));
            PriorityBox.DataSource = Enum.GetNames(typeof(TodoPriority));
        }

        private async void TodoEditorForm_LoadAsync(object sender, EventArgs e)
        {
            _users = await _userQueryService.GetAllAsync();
            _users.Insert(0, User.Empty);

            UsersBox.DataSource = _users;
            UsersBox.DisplayMember = nameof(User.Name);
            _pendingChanges = false;
        }

        private async void AddTodoButton_ClickAsync(object sender, EventArgs e)
        {
            AddTodoButton.Enabled = false;
            var newTodo = new Todo
            {
                Title = TitleTextBox.Text,
                Description = DescriptionTextBox.Text,
                StartDate = StartDatePicker.Value,
                DueDate = DueDatePicker.Value,
                Status = StatusBox.SelectedItem.ToString().ParseEnum<TodoStatus>(),
                Priority = PriorityBox.SelectedItem.ToString().ParseEnum<TodoPriority>()
            };

            if (UsersBox.SelectedItem is User selectedUser && !selectedUser.IsEmpty())
                newTodo.UserId = selectedUser.Id;

            var result = await _todoCommandService.AddAsync(newTodo);

            TodoCreated?.Invoke(this, result);

            _pendingChanges = false;
            AddTodoButton.Enabled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TodoEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_pendingChanges)
                e.Cancel = MessageBox.Show("Pending changes did not save. Do you want to close?", "Closing...", MessageBoxButtons.YesNo) == DialogResult.No;
        }

        private void InputChanged(object sender, EventArgs e)
        {
            _pendingChanges = true;
        }
    }
}