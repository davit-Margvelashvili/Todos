namespace Todos.WinFormsUi.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddTodoButton = new System.Windows.Forms.Button();
            this.TodoListBox = new System.Windows.Forms.ListBox();
            this.TodoListView = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // AddTodoButton
            // 
            this.AddTodoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.AddTodoButton.FlatAppearance.BorderSize = 0;
            this.AddTodoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(186)))), ((int)(((byte)(168)))));
            this.AddTodoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTodoButton.ForeColor = System.Drawing.Color.White;
            this.AddTodoButton.Location = new System.Drawing.Point(16, 563);
            this.AddTodoButton.Name = "AddTodoButton";
            this.AddTodoButton.Size = new System.Drawing.Size(351, 35);
            this.AddTodoButton.TabIndex = 0;
            this.AddTodoButton.Text = "Add Todo";
            this.AddTodoButton.UseVisualStyleBackColor = false;
            this.AddTodoButton.Click += new System.EventHandler(this.AddTodoButton_Click);
            // 
            // TodoListBox
            // 
            this.TodoListBox.FormattingEnabled = true;
            this.TodoListBox.ItemHeight = 22;
            this.TodoListBox.Location = new System.Drawing.Point(16, 12);
            this.TodoListBox.Name = "TodoListBox";
            this.TodoListBox.Size = new System.Drawing.Size(236, 532);
            this.TodoListBox.TabIndex = 8;
            // 
            // TodoListView
            // 
            this.TodoListView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.TodoListView.Location = new System.Drawing.Point(292, 12);
            this.TodoListView.Name = "TodoListView";
            this.TodoListView.Size = new System.Drawing.Size(742, 532);
            this.TodoListView.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1077, 610);
            this.Controls.Add(this.TodoListView);
            this.Controls.Add(this.TodoListBox);
            this.Controls.Add(this.AddTodoButton);
            this.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Todos";
            this.Load += new System.EventHandler(this.MainForm_LoadAsync);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddTodoButton;
        private System.Windows.Forms.ListBox TodoListBox;
        private System.Windows.Forms.FlowLayoutPanel TodoListView;
    }
}

