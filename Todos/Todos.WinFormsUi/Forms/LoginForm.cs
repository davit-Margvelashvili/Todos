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
using Todos.Core.Utils;

namespace Todos.WinFormsUi.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IUserCommandService _userService;

        public event EventHandler<User> Success;

        public LoginForm()
        {
            InitializeComponent();

            _userService = ServiceContainer.Get<IUserCommandService>();
        }

        private async void LoginButton_ClickAsync(object sender, EventArgs e)
        {
            await LoginAsync();
        }

        private async Task LoginAsync()
        {
            LoginButton.Enabled = false;

            if (!ValidateInput())
            {
                LoginButton.Enabled = true;
                return;
            }

            await LoginAsync(UserNameTextBox.Text, PasswordTextBox.Text);

            LoginButton.Enabled = true;
        }

        private async Task LoginAsync(string userName, string password)
        {
            var user = await _userService.LoginAsync(userName, password);
            if (user != null)
            {
                Success?.Invoke(this, user);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                ErrorLabel.Visible = true;
            }
        }

        private bool ValidateInput() =>
            UserNameTextBox.Validate(UserNameError)
            & PasswordTextBox.Validate(PasswordError);

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var registrationForm = new RegistrationForm();
            registrationForm.Success += OnSuccessfulRegistrationAsync;
            registrationForm.ShowDialog();
        }

        private async void OnSuccessfulRegistrationAsync(object sender, User e)
        {
            await LoginAsync(e.Email, e.Password);
        }
    }
}