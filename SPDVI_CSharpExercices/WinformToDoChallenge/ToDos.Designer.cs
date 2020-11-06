namespace WinformToDoChallenge
{
    partial class WinformToDo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.todoListBox = new System.Windows.Forms.ListBox();
            this.todoListBoxLabel = new System.Windows.Forms.Label();
            this.ToDoText = new System.Windows.Forms.TextBox();
            this.ToDoLabel = new System.Windows.Forms.Label();
            this.AddUpdateTodo = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // todoListBox
            // 
            this.todoListBox.FormattingEnabled = true;
            this.todoListBox.ItemHeight = 16;
            this.todoListBox.Location = new System.Drawing.Point(51, 116);
            this.todoListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.todoListBox.Name = "todoListBox";
            this.todoListBox.Size = new System.Drawing.Size(355, 372);
            this.todoListBox.TabIndex = 0;
            this.todoListBox.SelectedIndexChanged += new System.EventHandler(this.todoListBox_SelectedIndexChanged);
            this.todoListBox.DoubleClick += new System.EventHandler(this.todoListBox_DoubleClick);
            this.todoListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.todoListBox_KeyDown);
            this.todoListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.todoListBox_KeyPress);
            this.todoListBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.todoListBox_PreviewKeyDown);
            // 
            // todoListBoxLabel
            // 
            this.todoListBoxLabel.AutoSize = true;
            this.todoListBoxLabel.Location = new System.Drawing.Point(47, 96);
            this.todoListBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todoListBoxLabel.Name = "todoListBoxLabel";
            this.todoListBoxLabel.Size = new System.Drawing.Size(69, 17);
            this.todoListBoxLabel.TabIndex = 1;
            this.todoListBoxLabel.Text = "ToDo List";
            // 
            // ToDoText
            // 
            this.ToDoText.Location = new System.Drawing.Point(605, 135);
            this.ToDoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ToDoText.Name = "ToDoText";
            this.ToDoText.Size = new System.Drawing.Size(368, 22);
            this.ToDoText.TabIndex = 2;
            // 
            // ToDoLabel
            // 
            this.ToDoLabel.AutoSize = true;
            this.ToDoLabel.Location = new System.Drawing.Point(601, 116);
            this.ToDoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ToDoLabel.Name = "ToDoLabel";
            this.ToDoLabel.Size = new System.Drawing.Size(102, 17);
            this.ToDoLabel.TabIndex = 3;
            this.ToDoLabel.Text = "new ToDo Item";
            // 
            // AddUpdateTodo
            // 
            this.AddUpdateTodo.Location = new System.Drawing.Point(605, 186);
            this.AddUpdateTodo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddUpdateTodo.Name = "AddUpdateTodo";
            this.AddUpdateTodo.Size = new System.Drawing.Size(369, 28);
            this.AddUpdateTodo.TabIndex = 4;
            this.AddUpdateTodo.Text = "add ToDo Item";
            this.AddUpdateTodo.UseVisualStyleBackColor = true;
            this.AddUpdateTodo.Click += new System.EventHandler(this.AddUpdateTodo_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(456, 150);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 28);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(456, 186);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 28);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // WinformToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1693, 737);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.AddUpdateTodo);
            this.Controls.Add(this.ToDoLabel);
            this.Controls.Add(this.ToDoText);
            this.Controls.Add(this.todoListBoxLabel);
            this.Controls.Add(this.todoListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WinformToDo";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox todoListBox;
        private System.Windows.Forms.Label todoListBoxLabel;
        private System.Windows.Forms.TextBox ToDoText;
        private System.Windows.Forms.Label ToDoLabel;
        private System.Windows.Forms.Button AddUpdateTodo;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
    }
}

