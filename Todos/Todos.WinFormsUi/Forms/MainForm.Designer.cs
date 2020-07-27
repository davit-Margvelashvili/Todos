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
            this.TodoListView = new System.Windows.Forms.FlowLayoutPanel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.todoGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.todoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTodoButton
            // 
            this.AddTodoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.AddTodoButton.FlatAppearance.BorderSize = 0;
            this.AddTodoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(186)))), ((int)(((byte)(168)))));
            this.AddTodoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTodoButton.ForeColor = System.Drawing.Color.White;
            this.AddTodoButton.Location = new System.Drawing.Point(292, 550);
            this.AddTodoButton.Name = "AddTodoButton";
            this.AddTodoButton.Size = new System.Drawing.Size(773, 35);
            this.AddTodoButton.TabIndex = 0;
            this.AddTodoButton.Text = "Add Todo";
            this.AddTodoButton.UseVisualStyleBackColor = false;
            this.AddTodoButton.Click += new System.EventHandler(this.AddTodoButton_Click);
            // 
            // TodoListView
            // 
            this.TodoListView.AutoScroll = true;
            this.TodoListView.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.TodoListView.Location = new System.Drawing.Point(292, 12);
            this.TodoListView.Name = "TodoListView";
            this.TodoListView.Size = new System.Drawing.Size(773, 532);
            this.TodoListView.TabIndex = 9;
            this.TodoListView.WrapContents = false;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(24, 34);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(51, 22);
            this.UserNameLabel.TabIndex = 10;
            this.UserNameLabel.Text = "Hello ";
            // 
            // todoGrid
            // 
            this.todoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.todoGrid.Location = new System.Drawing.Point(13, 72);
            this.todoGrid.Name = "todoGrid";
            this.todoGrid.Size = new System.Drawing.Size(240, 218);
            this.todoGrid.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1077, 610);
            this.Controls.Add(this.todoGrid);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.TodoListView);
            this.Controls.Add(this.AddTodoButton);
            this.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Todos";
            this.Load += new System.EventHandler(this.MainForm_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.todoGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTodoButton;
        private System.Windows.Forms.FlowLayoutPanel TodoListView;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.DataGridView todoGrid;
    }
}

