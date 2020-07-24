namespace Todos.WinFormsUi.Forms
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.RepeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.RepeatPasswordLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameError = new System.Windows.Forms.Label();
            this.UserNameError = new System.Windows.Forms.Label();
            this.PasswordError = new System.Windows.Forms.Label();
            this.RepeatPasswordError = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.PasswordMatchError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Todos.WinFormsUi.Properties.Resources.register;
            this.pictureBox1.Location = new System.Drawing.Point(205, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.PasswordLabel.Location = new System.Drawing.Point(12, 337);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(72, 22);
            this.PasswordLabel.TabIndex = 21;
            this.PasswordLabel.Text = "Password";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.UserNameLabel.Location = new System.Drawing.Point(12, 277);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(49, 22);
            this.UserNameLabel.TabIndex = 22;
            this.UserNameLabel.Text = "Email";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 362);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(495, 29);
            this.PasswordTextBox.TabIndex = 30;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(12, 302);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(495, 29);
            this.UserNameTextBox.TabIndex = 20;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(126)))), ((int)(((byte)(163)))));
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(12, 466);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(495, 32);
            this.RegisterButton.TabIndex = 50;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_ClickAsync);
            // 
            // RepeatPasswordTextBox
            // 
            this.RepeatPasswordTextBox.Location = new System.Drawing.Point(12, 422);
            this.RepeatPasswordTextBox.Name = "RepeatPasswordTextBox";
            this.RepeatPasswordTextBox.Size = new System.Drawing.Size(495, 29);
            this.RepeatPasswordTextBox.TabIndex = 40;
            this.RepeatPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // RepeatPasswordLabel
            // 
            this.RepeatPasswordLabel.AutoSize = true;
            this.RepeatPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.RepeatPasswordLabel.Location = new System.Drawing.Point(12, 397);
            this.RepeatPasswordLabel.Name = "RepeatPasswordLabel";
            this.RepeatPasswordLabel.Size = new System.Drawing.Size(120, 22);
            this.RepeatPasswordLabel.TabIndex = 21;
            this.RepeatPasswordLabel.Text = "Repeat Password";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.FullNameLabel.Location = new System.Drawing.Point(12, 216);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(80, 22);
            this.FullNameLabel.TabIndex = 32;
            this.FullNameLabel.Text = "Full Name";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(12, 241);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(495, 29);
            this.FullNameTextBox.TabIndex = 10;
            // 
            // fullNameError
            // 
            this.fullNameError.AutoSize = true;
            this.fullNameError.ForeColor = System.Drawing.Color.Maroon;
            this.fullNameError.Location = new System.Drawing.Point(89, 216);
            this.fullNameError.Name = "fullNameError";
            this.fullNameError.Size = new System.Drawing.Size(80, 22);
            this.fullNameError.TabIndex = 32;
            this.fullNameError.Text = "is required";
            this.fullNameError.Visible = false;
            // 
            // UserNameError
            // 
            this.UserNameError.AutoSize = true;
            this.UserNameError.ForeColor = System.Drawing.Color.Maroon;
            this.UserNameError.Location = new System.Drawing.Point(58, 277);
            this.UserNameError.Name = "UserNameError";
            this.UserNameError.Size = new System.Drawing.Size(80, 22);
            this.UserNameError.TabIndex = 34;
            this.UserNameError.Text = "is required";
            this.UserNameError.Visible = false;
            // 
            // PasswordError
            // 
            this.PasswordError.AutoSize = true;
            this.PasswordError.ForeColor = System.Drawing.Color.Maroon;
            this.PasswordError.Location = new System.Drawing.Point(80, 337);
            this.PasswordError.Name = "PasswordError";
            this.PasswordError.Size = new System.Drawing.Size(80, 22);
            this.PasswordError.TabIndex = 35;
            this.PasswordError.Text = "is required";
            this.PasswordError.Visible = false;
            // 
            // RepeatPasswordError
            // 
            this.RepeatPasswordError.AutoSize = true;
            this.RepeatPasswordError.ForeColor = System.Drawing.Color.Maroon;
            this.RepeatPasswordError.Location = new System.Drawing.Point(128, 397);
            this.RepeatPasswordError.Name = "RepeatPasswordError";
            this.RepeatPasswordError.Size = new System.Drawing.Size(80, 22);
            this.RepeatPasswordError.TabIndex = 36;
            this.RepeatPasswordError.Text = "is required";
            this.RepeatPasswordError.Visible = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.ErrorLabel.Location = new System.Drawing.Point(149, 177);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(221, 22);
            this.ErrorLabel.TabIndex = 37;
            this.ErrorLabel.Text = "User has already been registered";
            this.ErrorLabel.Visible = false;
            // 
            // PasswordMatchError
            // 
            this.PasswordMatchError.AutoSize = true;
            this.PasswordMatchError.ForeColor = System.Drawing.Color.Maroon;
            this.PasswordMatchError.Location = new System.Drawing.Point(128, 397);
            this.PasswordMatchError.Name = "PasswordMatchError";
            this.PasswordMatchError.Size = new System.Drawing.Size(108, 22);
            this.PasswordMatchError.TabIndex = 38;
            this.PasswordMatchError.Text = "does not match";
            this.PasswordMatchError.Visible = false;
            // 
            // RegistrationForm
            // 
            this.AcceptButton = this.RegisterButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(519, 507);
            this.Controls.Add(this.PasswordMatchError);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.RepeatPasswordError);
            this.Controls.Add(this.PasswordError);
            this.Controls.Add(this.UserNameError);
            this.Controls.Add(this.fullNameError);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.RepeatPasswordLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.RepeatPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox RepeatPasswordTextBox;
        private System.Windows.Forms.Label RepeatPasswordLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label fullNameError;
        private System.Windows.Forms.Label UserNameError;
        private System.Windows.Forms.Label PasswordError;
        private System.Windows.Forms.Label RepeatPasswordError;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label PasswordMatchError;
    }
}