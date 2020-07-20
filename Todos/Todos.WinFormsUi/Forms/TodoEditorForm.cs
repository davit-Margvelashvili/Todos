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
        private List<User> _users;

        public event EventHandler<Todo> TodoCreated;

        public TodoEditorForm()
        {
            InitializeComponent();

            _todoCommandService = ServiceContainer.Get<ITodoCommandService>();
            _userQueryService = ServiceContainer.Get<IUserQueryService>();

            StatusBox.DataSource = Enum.GetNames(typeof(TodoStatus));
            PriorityBox.DataSource = Enum.GetNames(typeof(TodoPriority));
        }

        private async void TodoEditorForm_LoadAsync(object sender, EventArgs e)
        {
            _users = await _userQueryService.GetAllAsync();
            _users.Insert(0, User.Empty);

            UsersBox.DataSource = _users;
            UsersBox.DisplayMember = nameof(User.Name);
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

            AddTodoButton.Enabled = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TodoEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Do you want to close?", "Closing...", MessageBoxButtons.YesNo) == DialogResult.No;
        }
    }
}