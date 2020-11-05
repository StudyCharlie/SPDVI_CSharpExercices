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
            this.todoListBox.Location = new System.Drawing.Point(38, 94);
            this.todoListBox.Name = "todoListBox";
            this.todoListBox.Size = new System.Drawing.Size(267, 303);
            this.todoListBox.TabIndex = 0;
            this.todoListBox.DoubleClick += new System.EventHandler(this.todoListBox_DoubleClick);
            this.todoListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.todoListBox_KeyDown);
            this.todoListBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.todoListBox_KeyPress);
            this.todoListBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.todoListBox_PreviewKeyDown);
            // 
            // todoListBoxLabel
            // 
            this.todoListBoxLabel.AutoSize = true;
            this.todoListBoxLabel.Location = new System.Drawing.Point(35, 78);
            this.todoListBoxLabel.Name = "todoListBoxLabel";
            this.todoListBoxLabel.Size = new System.Drawing.Size(53, 13);
            this.todoListBoxLabel.TabIndex = 1;
            this.todoListBoxLabel.Text = "ToDo List";
            // 
            // ToDoText
            // 
            this.ToDoText.Location = new System.Drawing.Point(454, 110);
            this.ToDoText.Name = "ToDoText";
            this.ToDoText.Size = new System.Drawing.Size(277, 20);
            this.ToDoText.TabIndex = 2;
            // 
            // ToDoLabel
            // 
            this.ToDoLabel.AutoSize = true;
            this.ToDoLabel.Location = new System.Drawing.Point(451, 94);
            this.ToDoLabel.Name = "ToDoLabel";
            this.ToDoLabel.Size = new System.Drawing.Size(80, 13);
            this.ToDoLabel.TabIndex = 3;
            this.ToDoLabel.Text = "new ToDo Item";
            // 
            // AddUpdateTodo
            // 
            this.AddUpdateTodo.Location = new System.Drawing.Point(454, 151);
            this.AddUpdateTodo.Name = "AddUpdateTodo";
            this.AddUpdateTodo.Size = new System.Drawing.Size(277, 23);
            this.AddUpdateTodo.TabIndex = 4;
            this.AddUpdateTodo.Text = "add ToDo Item";
            this.AddUpdateTodo.UseVisualStyleBackColor = true;
            this.AddUpdateTodo.Click += new System.EventHandler(this.AddUpdateTodo_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(342, 122);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(342, 151);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // WinformToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 599);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.AddUpdateTodo);
            this.Controls.Add(this.ToDoLabel);
            this.Controls.Add(this.ToDoText);
            this.Controls.Add(this.todoListBoxLabel);
            this.Controls.Add(this.todoListBox);
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

