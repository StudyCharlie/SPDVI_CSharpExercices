namespace WinformToDo
{
    partial class ToDo
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
            this.todoListBox = new System.Windows.Forms.ListBox();
            this.todoListBoxLabel = new System.Windows.Forms.Label();
            this.newTodoText = new System.Windows.Forms.TextBox();
            this.newToDoLabel = new System.Windows.Forms.Label();
            this.addNewToDo = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // todoListBox
            // 
            this.todoListBox.FormattingEnabled = true;
            this.todoListBox.ItemHeight = 29;
            this.todoListBox.Location = new System.Drawing.Point(36, 103);
            this.todoListBox.Name = "todoListBox";
            this.todoListBox.Size = new System.Drawing.Size(207, 352);
            this.todoListBox.TabIndex = 0;
            // 
            // todoListBoxLabel
            // 
            this.todoListBoxLabel.AutoSize = true;
            this.todoListBoxLabel.Location = new System.Drawing.Point(31, 71);
            this.todoListBoxLabel.Name = "todoListBoxLabel";
            this.todoListBoxLabel.Size = new System.Drawing.Size(117, 29);
            this.todoListBoxLabel.TabIndex = 1;
            this.todoListBoxLabel.Text = "ToDo List";
            // 
            // newTodoText
            // 
            this.newTodoText.Location = new System.Drawing.Point(408, 211);
            this.newTodoText.Name = "newTodoText";
            this.newTodoText.Size = new System.Drawing.Size(289, 35);
            this.newTodoText.TabIndex = 2;
            // 
            // newToDoLabel
            // 
            this.newToDoLabel.AutoSize = true;
            this.newToDoLabel.Location = new System.Drawing.Point(403, 179);
            this.newToDoLabel.Name = "newToDoLabel";
            this.newToDoLabel.Size = new System.Drawing.Size(188, 29);
            this.newToDoLabel.TabIndex = 3;
            this.newToDoLabel.Text = "New To Do Item";
            // 
            // addNewToDo
            // 
            this.addNewToDo.Location = new System.Drawing.Point(408, 263);
            this.addNewToDo.Name = "addNewToDo";
            this.addNewToDo.Size = new System.Drawing.Size(289, 40);
            this.addNewToDo.TabIndex = 4;
            this.addNewToDo.Text = "Add ToDo Item";
            this.addNewToDo.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(249, 179);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(104, 58);
            this.editButton.TabIndex = 5;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(249, 263);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 58);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 526);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addNewToDo);
            this.Controls.Add(this.newToDoLabel);
            this.Controls.Add(this.newTodoText);
            this.Controls.Add(this.todoListBoxLabel);
            this.Controls.Add(this.todoListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "ToDo";
            this.Text = "ToDo List";
            this.Load += new System.EventHandler(this.ToDo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox todoListBox;
        private System.Windows.Forms.Label todoListBoxLabel;
        private System.Windows.Forms.TextBox newTodoText;
        private System.Windows.Forms.Label newToDoLabel;
        private System.Windows.Forms.Button addNewToDo;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
    }
}