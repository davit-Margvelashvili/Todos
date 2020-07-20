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
using Color = System.Drawing.Color;

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

        #region Event Handlers

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

            if (!ValidateInput())
            {
                AddTodoButton.Enabled = true;
                return;
            }

            await AddTodoAsync();

            //RestoreDefaultValues();

            _pendingChanges = false;
            AddTodoButton.Enabled = true;
            Close();
        }

        private bool ValidateInput()
        {
            if (TitleTextBox.Text.IsNullOrWhiteSpace())
            {
                TitleLabel.ForeColor = Color.Maroon;
                titleErrorLabel.Visible = true;
                return false;
            }

            return true;
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

        #endregion Event Handlers

        #region Helper Methods

        private async Task AddTodoAsync()
        {
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
        }

        private void RestoreDefaultValues()
        {
            TitleTextBox.Clear();
            DescriptionTextBox.Clear();
            StartDatePicker.Value = _dateTimeProvider.Today;
            DueDatePicker.Value = _dateTimeProvider.Today;

            StatusBox.SelectedIndex = 0;
            PriorityBox.SelectedIndex = 0;
            UsersBox.SelectedIndex = 0;
        }

        #endregion Helper Methods
    }
}