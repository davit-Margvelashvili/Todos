namespace Todos.WinFormsUi.Forms
{
    partial class TodoEditorForm
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
            this.DueDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.AddTodoButton = new System.Windows.Forms.Button();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.ComboBox();
            this.PriorityBox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.PriotiryLabel = new System.Windows.Forms.Label();
            this.UsersBox = new System.Windows.Forms.ComboBox();
            this.AssignToLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DueDatePicker
            // 
            this.DueDatePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(239)))), ((int)(((byte)(145)))));
            this.DueDatePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DueDatePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DueDatePicker.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDatePicker.Location = new System.Drawing.Point(12, 142);
            this.DueDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DueDatePicker.Name = "DueDatePicker";
            this.DueDatePicker.Size = new System.Drawing.Size(320, 25);
            this.DueDatePicker.TabIndex = 15;
            this.DueDatePicker.ValueChanged += new System.EventHandler(this.InputChanged);
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.StartDateLabel.Location = new System.Drawing.Point(12, 68);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(61, 18);
            this.StartDateLabel.TabIndex = 14;
            this.StartDateLabel.Text = "Start Date";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(239)))), ((int)(((byte)(145)))));
            this.StartDatePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.StartDatePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.StartDatePicker.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDatePicker.Location = new System.Drawing.Point(12, 89);
            this.StartDatePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(320, 25);
            this.StartDatePicker.TabIndex = 13;
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.InputChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 295);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(69, 18);
            this.DescriptionLabel.TabIndex = 12;
            this.DescriptionLabel.Text = "Description";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.TitleLabel.Location = new System.Drawing.Point(12, 15);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(32, 18);
            this.TitleLabel.TabIndex = 11;
            this.TitleLabel.Text = "Title";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 319);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(320, 124);
            this.DescriptionTextBox.TabIndex = 9;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.InputChanged);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTextBox.Location = new System.Drawing.Point(12, 35);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(320, 25);
            this.TitleTextBox.TabIndex = 10;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.InputChanged);
            // 
            // AddTodoButton
            // 
            this.AddTodoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.AddTodoButton.FlatAppearance.BorderSize = 0;
            this.AddTodoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(186)))), ((int)(((byte)(168)))));
            this.AddTodoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTodoButton.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTodoButton.ForeColor = System.Drawing.Color.White;
            this.AddTodoButton.Location = new System.Drawing.Point(12, 449);
            this.AddTodoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddTodoButton.Name = "AddTodoButton";
            this.AddTodoButton.Size = new System.Drawing.Size(157, 35);
            this.AddTodoButton.TabIndex = 8;
            this.AddTodoButton.Text = "Add Todo";
            this.AddTodoButton.UseVisualStyleBackColor = false;
            this.AddTodoButton.Click += new System.EventHandler(this.AddTodoButton_ClickAsync);
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DueDateLabel.Location = new System.Drawing.Point(12, 120);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(58, 18);
            this.DueDateLabel.TabIndex = 16;
            this.DueDateLabel.Text = "Due Date";
            // 
            // StatusBox
            // 
            this.StatusBox.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBox.FormattingEnabled = true;
            this.StatusBox.Location = new System.Drawing.Point(12, 194);
            this.StatusBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.Size = new System.Drawing.Size(157, 26);
            this.StatusBox.TabIndex = 17;
            this.StatusBox.SelectedIndexChanged += new System.EventHandler(this.InputChanged);
            // 
            // PriorityBox
            // 
            this.PriorityBox.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriorityBox.FormattingEnabled = true;
            this.PriorityBox.Location = new System.Drawing.Point(175, 194);
            this.PriorityBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PriorityBox.Name = "PriorityBox";
            this.PriorityBox.Size = new System.Drawing.Size(157, 26);
            this.PriorityBox.TabIndex = 18;
            this.PriorityBox.SelectedIndexChanged += new System.EventHandler(this.InputChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.StatusLabel.Location = new System.Drawing.Point(12, 172);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(39, 18);
            this.StatusLabel.TabIndex = 19;
            this.StatusLabel.Text = "Status";
            // 
            // PriotiryLabel
            // 
            this.PriotiryLabel.AutoSize = true;
            this.PriotiryLabel.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriotiryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.PriotiryLabel.Location = new System.Drawing.Point(175, 172);
            this.PriotiryLabel.Name = "PriotiryLabel";
            this.PriotiryLabel.Size = new System.Drawing.Size(50, 18);
            this.PriotiryLabel.TabIndex = 20;
            this.PriotiryLabel.Text = "Priority";
            // 
            // UsersBox
            // 
            this.UsersBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.UsersBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.UsersBox.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersBox.FormattingEnabled = true;
            this.UsersBox.Location = new System.Drawing.Point(12, 248);
            this.UsersBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsersBox.Name = "UsersBox";
            this.UsersBox.Size = new System.Drawing.Size(324, 26);
            this.UsersBox.TabIndex = 21;
            this.UsersBox.SelectedIndexChanged += new System.EventHandler(this.InputChanged);
            // 
            // AssignToLabel
            // 
            this.AssignToLabel.AutoSize = true;
            this.AssignToLabel.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.AssignToLabel.Location = new System.Drawing.Point(12, 227);
            this.AssignToLabel.Name = "AssignToLabel";
            this.AssignToLabel.Size = new System.Drawing.Size(72, 18);
            this.AssignToLabel.TabIndex = 22;
            this.AssignToLabel.Text = "Assigned To";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(175, 449);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(157, 35);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TodoEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 496);
            this.Controls.Add(this.AssignToLabel);
            this.Controls.Add(this.UsersBox);
            this.Controls.Add(this.PriotiryLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.PriorityBox);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.DueDateLabel);
            this.Controls.Add(this.DueDatePicker);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddTodoButton);
            this.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(361, 535);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(361, 535);
            this.Name = "TodoEditorForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TodoEditorForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TodoEditorForm_FormClosing);
            this.Load += new System.EventHandler(this.TodoEditorForm_LoadAsync);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DueDatePicker;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button AddTodoButton;
        private System.Windows.Forms.Label DueDateLabel;
        private System.Windows.Forms.ComboBox StatusBox;
        private System.Windows.Forms.ComboBox PriorityBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label PriotiryLabel;
        private System.Windows.Forms.ComboBox UsersBox;
        private System.Windows.Forms.Label AssignToLabel;
        private System.Windows.Forms.Button CancelButton;
    }
}