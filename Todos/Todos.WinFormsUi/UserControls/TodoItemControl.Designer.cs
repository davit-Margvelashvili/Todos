namespace Todos.WinFormsUi.UserControls
{
    partial class TodoItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodoItemControl));
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.UserBox = new System.Windows.Forms.ComboBox();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.PriorityBox = new System.Windows.Forms.ComboBox();
            this.AssignedToLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EditButton)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleTextBox.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.TitleTextBox.Location = new System.Drawing.Point(10, 6);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(335, 26);
            this.TitleTextBox.TabIndex = 0;
            this.TitleTextBox.Text = "Lorem ipsum";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.DescriptionTextBox.Location = new System.Drawing.Point(10, 41);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(335, 73);
            this.DescriptionTextBox.TabIndex = 0;
            this.DescriptionTextBox.Text = resources.GetString("DescriptionTextBox.Text");
            // 
            // UserBox
            // 
            this.UserBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserBox.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBox.FormattingEnabled = true;
            this.UserBox.Location = new System.Drawing.Point(435, 6);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(260, 22);
            this.UserBox.TabIndex = 1;
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.CustomFormat = "dd/MM/yyyy";
            this.StartDatePicker.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartDatePicker.Location = new System.Drawing.Point(567, 42);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(160, 22);
            this.StartDatePicker.TabIndex = 2;
            // 
            // DueDatePicker
            // 
            this.DueDatePicker.CustomFormat = "dd/MM/yyyy";
            this.DueDatePicker.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DueDatePicker.Location = new System.Drawing.Point(567, 75);
            this.DueDatePicker.Name = "DueDatePicker";
            this.DueDatePicker.Size = new System.Drawing.Size(160, 22);
            this.DueDatePicker.TabIndex = 3;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.StartDateLabel.Location = new System.Drawing.Point(531, 44);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(34, 18);
            this.StartDateLabel.TabIndex = 4;
            this.StartDateLabel.Text = "Start";
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DueDateLabel.Location = new System.Drawing.Point(531, 77);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(31, 18);
            this.DueDateLabel.TabIndex = 4;
            this.DueDateLabel.Text = "Due";
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.PriorityLabel.Location = new System.Drawing.Point(355, 77);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(50, 18);
            this.PriorityLabel.TabIndex = 5;
            this.PriorityLabel.Text = "Priority";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.StatusLabel.Location = new System.Drawing.Point(355, 44);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(42, 18);
            this.StatusLabel.TabIndex = 6;
            this.StatusLabel.Text = "Status";
            // 
            // StatusBox
            // 
            this.StatusBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusBox.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(404, 42);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(121, 22);
            this.StatusBox.TabIndex = 7;
            // 
            // PriorityBox
            // 
            this.PriorityBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PriorityBox.Font = new System.Drawing.Font("Sylfaen", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityBox.FormattingEnabled = true;
            this.PriorityBox.Location = new System.Drawing.Point(404, 75);
            this.PriorityBox.Name = "PriorityBox";
            this.PriorityBox.Size = new System.Drawing.Size(121, 22);
            this.PriorityBox.TabIndex = 7;
            // 
            // AssignedToLabel
            // 
            this.AssignedToLabel.AutoSize = true;
            this.AssignedToLabel.Font = new System.Drawing.Font("Sylfaen", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignedToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.AssignedToLabel.Location = new System.Drawing.Point(355, 6);
            this.AssignedToLabel.Name = "AssignedToLabel";
            this.AssignedToLabel.Size = new System.Drawing.Size(75, 18);
            this.AssignedToLabel.TabIndex = 8;
            this.AssignedToLabel.Text = "Assigned to";
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EditButton.Location = new System.Drawing.Point(711, 6);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(26, 22);
            this.EditButton.TabIndex = 9;
            this.EditButton.TabStop = false;
            // 
            // TodoItemControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AssignedToLabel);
            this.Controls.Add(this.PriorityBox);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.PriorityLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.DueDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.DueDatePicker);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TodoItemControl";
            this.Size = new System.Drawing.Size(740, 118);
            ((System.ComponentModel.ISupportInitialize)(this.EditButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.ComboBox UserBox;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.DateTimePicker DueDatePicker;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label DueDateLabel;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.ComboBox PriorityBox;
        private System.Windows.Forms.Label AssignedToLabel;
        private System.Windows.Forms.PictureBox EditButton;
    }
}
