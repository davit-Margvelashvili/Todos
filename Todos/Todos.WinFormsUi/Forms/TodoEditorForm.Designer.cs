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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.PriotiryLabel = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.AssignToLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DueDatePicker
            // 
            this.DueDatePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(239)))), ((int)(((byte)(145)))));
            this.DueDatePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DueDatePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DueDatePicker.Font = new System.Drawing.Font("Sylfaen", 11F);
            this.DueDatePicker.Location = new System.Drawing.Point(12, 142);
            this.DueDatePicker.Name = "DueDatePicker";
            this.DueDatePicker.Size = new System.Drawing.Size(320, 27);
            this.DueDatePicker.TabIndex = 15;
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Sylfaen", 11F);
            this.StartDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.StartDateLabel.Location = new System.Drawing.Point(11, 68);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(72, 19);
            this.StartDateLabel.TabIndex = 14;
            this.StartDateLabel.Text = "Start Date";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(6)))), ((int)(((byte)(239)))), ((int)(((byte)(145)))));
            this.StartDatePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.StartDatePicker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.StartDatePicker.Font = new System.Drawing.Font("Sylfaen", 11F);
            this.StartDatePicker.Location = new System.Drawing.Point(12, 89);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(320, 27);
            this.StartDatePicker.TabIndex = 13;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DescriptionLabel.Location = new System.Drawing.Point(12, 294);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(87, 22);
            this.DescriptionLabel.TabIndex = 12;
            this.DescriptionLabel.Text = "Description";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Sylfaen", 11F);
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.TitleLabel.Location = new System.Drawing.Point(12, 15);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(36, 19);
            this.TitleLabel.TabIndex = 11;
            this.TitleLabel.Text = "Title";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(12, 319);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(320, 124);
            this.DescriptionTextBox.TabIndex = 9;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(12, 36);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(320, 29);
            this.TitleTextBox.TabIndex = 10;
            // 
            // AddTodoButton
            // 
            this.AddTodoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.AddTodoButton.FlatAppearance.BorderSize = 0;
            this.AddTodoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(186)))), ((int)(((byte)(168)))));
            this.AddTodoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTodoButton.ForeColor = System.Drawing.Color.White;
            this.AddTodoButton.Location = new System.Drawing.Point(12, 449);
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
            this.DueDateLabel.Font = new System.Drawing.Font("Sylfaen", 11F);
            this.DueDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.DueDateLabel.Location = new System.Drawing.Point(12, 120);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(68, 19);
            this.DueDateLabel.TabIndex = 16;
            this.DueDateLabel.Text = "Due Date";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 30);
            this.comboBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(175, 194);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(157, 30);
            this.comboBox2.TabIndex = 18;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Sylfaen", 11F);
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.StatusLabel.Location = new System.Drawing.Point(12, 172);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(46, 19);
            this.StatusLabel.TabIndex = 19;
            this.StatusLabel.Text = "Status";
            // 
            // PriotiryLabel
            // 
            this.PriotiryLabel.AutoSize = true;
            this.PriotiryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.PriotiryLabel.Location = new System.Drawing.Point(175, 172);
            this.PriotiryLabel.Name = "PriotiryLabel";
            this.PriotiryLabel.Size = new System.Drawing.Size(62, 22);
            this.PriotiryLabel.TabIndex = 20;
            this.PriotiryLabel.Text = "Priority";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(12, 248);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(324, 30);
            this.comboBox3.TabIndex = 21;
            // 
            // AssignToLabel
            // 
            this.AssignToLabel.AutoSize = true;
            this.AssignToLabel.Font = new System.Drawing.Font("Sylfaen", 11F);
            this.AssignToLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.AssignToLabel.Location = new System.Drawing.Point(12, 227);
            this.AssignToLabel.Name = "AssignToLabel";
            this.AssignToLabel.Size = new System.Drawing.Size(85, 19);
            this.AssignToLabel.TabIndex = 22;
            this.AssignToLabel.Text = "Assigned To";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(186)))), ((int)(((byte)(168)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(175, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TodoEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 496);
            this.Controls.Add(this.AssignToLabel);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.PriotiryLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DueDateLabel);
            this.Controls.Add(this.DueDatePicker);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddTodoButton);
            this.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(361, 535);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(361, 535);
            this.Name = "TodoEditorForm";
            this.Text = "TodoEditorForm";
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label PriotiryLabel;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label AssignToLabel;
        private System.Windows.Forms.Button button1;
    }
}