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
using Todos.Core.Exceptions;
using Todos.Core.Models;
using Todos.Core.Utils;

namespace Todos.WinFormsUi.Forms
{
    public partial class RegistrationForm : Form
    {
        private readonly IUserCommandService _service;

        public event EventHandler<User> Success;

        public RegistrationForm()
        {
            InitializeComponent();
            _service = ServiceContainer.Get<IUserCommandService>();
        }

        private async void RegisterButton_ClickAsync(object sender, EventArgs e)
        {
            RegisterButton.Enabled = false;
            if (!ValidateInput())
            {
                RegisterButton.Enabled = true;
                return;
            }
            var newUser = new User
            {
                Name = FullNameTextBox.Text,
                Email = UserNameTextBox.Text,
                Password = PasswordTextBox.Text
            };

            try
            {
                var registeredUser = await _service.RegisterAsync(newUser);
                Success?.Invoke(this, registeredUser);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (UserAlreadyRegisteredException)
            {
                ErrorLabel.Visible = true;
            }

            RegisterButton.Enabled = true;
        }

        private bool ValidateInput() =>
            FullNameTextBox.Validate(fullNameError)
            & UserNameTextBox.Validate(UserNameError)
            & PasswordTextBox.Validate(PasswordError)
            & RepeatPasswordTextBox.Validate(RepeatPasswordError)
            & ValidateRepeatPassword();

        private bool ValidateRepeatPassword()
        {
            if (PasswordTextBox.Text == RepeatPasswordTextBox.Text)
            {
                PasswordMatchError.Visible = false;
                return true;
            }

            if (RepeatPasswordError.Visible)
                RepeatPasswordError.Visible = false;
            PasswordMatchError.Visible = true;
            return false;
        }
    }
}