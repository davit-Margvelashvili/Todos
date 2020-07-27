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
            this.TodoGrid = new System.Windows.Forms.DataGridView();
            this.SaveChangesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TodoGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTodoButton
            // 
            this.AddTodoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.AddTodoButton.FlatAppearance.BorderSize = 0;
            this.AddTodoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(186)))), ((int)(((byte)(168)))));
            this.AddTodoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTodoButton.ForeColor = System.Drawing.Color.White;
            this.AddTodoButton.Location = new System.Drawing.Point(12, 563);
            this.AddTodoButton.Name = "AddTodoButton";
            this.AddTodoButton.Size = new System.Drawing.Size(198, 35);
            this.AddTodoButton.TabIndex = 0;
            this.AddTodoButton.Text = "Add Todo";
            this.AddTodoButton.UseVisualStyleBackColor = false;
            this.AddTodoButton.Click += new System.EventHandler(this.AddTodoButton_Click);
            // 
            // TodoGrid
            // 
            this.TodoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TodoGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.TodoGrid.Location = new System.Drawing.Point(216, 0);
            this.TodoGrid.Name = "TodoGrid";
            this.TodoGrid.Size = new System.Drawing.Size(861, 610);
            this.TodoGrid.TabIndex = 1;
            this.TodoGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TodoGrid_CellValueChanged);
            // 
            // SaveChangesButton
            // 
            this.SaveChangesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(122)))), ((int)(((byte)(111)))));
            this.SaveChangesButton.FlatAppearance.BorderSize = 0;
            this.SaveChangesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(186)))), ((int)(((byte)(168)))));
            this.SaveChangesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChangesButton.ForeColor = System.Drawing.Color.White;
            this.SaveChangesButton.Location = new System.Drawing.Point(12, 522);
            this.SaveChangesButton.Name = "SaveChangesButton";
            this.SaveChangesButton.Size = new System.Drawing.Size(198, 35);
            this.SaveChangesButton.TabIndex = 2;
            this.SaveChangesButton.Text = "Save Changes";
            this.SaveChangesButton.UseVisualStyleBackColor = false;
            this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_ClickAsync);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1077, 610);
            this.Controls.Add(this.SaveChangesButton);
            this.Controls.Add(this.TodoGrid);
            this.Controls.Add(this.AddTodoButton);
            this.Font = new System.Drawing.Font("Sylfaen", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Todos";
            this.Load += new System.EventHandler(this.MainForm_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.TodoGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddTodoButton;
        private System.Windows.Forms.DataGridView TodoGrid;
        private System.Windows.Forms.Button SaveChangesButton;
    }
}

