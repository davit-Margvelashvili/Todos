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
            LoginButton.Enabled = false;
            var userName = UserNameTextBox.Text;
            var password = PasswordTextBox.Text;

            // TODO უკეთესი ვალიდაცია დაამატეთ
            if (userName.IsNullOrWhiteSpace() || password.IsNullOrWhiteSpace())
            {
                LoginButton.Enabled = true;
                return;
            }

            var user = await _userService.LoginAsync(UserNameTextBox.Text, PasswordTextBox.Text);
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
            LoginButton.Enabled = true;
        }
    }
}