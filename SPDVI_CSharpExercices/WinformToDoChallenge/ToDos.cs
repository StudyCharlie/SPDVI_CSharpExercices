using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformToDoChallenge
{
    public partial class WinformToDo : Form
    {

        BindingList<TodoItemModel> todoList = new BindingList<TodoItemModel>();
        TodoItemModel currentEdit = null;

        public WinformToDo()
        {
            InitializeComponent();

            todoListBox.DataSource = todoList;
            todoListBox.DisplayMember = nameof(TodoItemModel.ToDoDisplay);
        }

        private void AddTodo(string todoText)
        {
            TodoItemModel todo = new TodoItemModel
            {
                PositionNumber = todoList.Count + 1,
                TodoText = todoText
            };

            todoList.Add(todo);
        }

        private void ReorderTodos()
        {
            for (int i = 0; i < todoList.Count; i++)
            {
                todoList[i].PositionNumber = (i + 1);
            }
        }

        private void DeleteItem(TodoItemModel todo)
        {
            todoList.Remove(todo);
            ReorderTodos();
        }

        private void StartEditingItem(TodoItemModel todo)
        {
            currentEdit = todo;
            ToDoLabel.Text = "Update ToDo Item";
            AddUpdateTodo.Text = "Edit ToDo Item";
            ToDoText.Text = currentEdit.TodoText;
        }

        private void CompleteEditingItem()
        {
            currentEdit.TodoText = ToDoText.Text;
            currentEdit = null;
            ToDoLabel.Text = "New ToDo Item";
            AddUpdateTodo.Text = "Add ToDo Item";
        }

        private void CompleteItem(TodoItemModel todo)
        {
            todo.IsComplete = true;
        }

        private void MoveItemUp(TodoItemModel todo)
        {
            if(todo.PositionNumber == 1)
            {
                return;
            }

            todoList.Remove(todo);
            todoList.Insert(todo.PositionNumber - 2, todo);
            ReorderTodos();
        }

        private void MoveItemDown(TodoItemModel todo)
        {
            if (todo.PositionNumber > todoList.Count)
            {
                return;
            }

            todoList.Remove(todo);
            todoList.Insert(todo.PositionNumber, todo);
            ReorderTodos();
        }

        private void AddUpdateTodo_Click(object sender, EventArgs e)
        {
            if(currentEdit == null)
            {
                AddTodo(ToDoText.Text);
            }
            else
            {
                CompleteEditingItem();
            }

            ToDoText.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if(todoListBox.SelectedItem != null)
            {
                TodoItemModel todo = (TodoItemModel)todoListBox.SelectedItem;
                StartEditingItem(todo);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (todoListBox.SelectedItem != null)
            {
                TodoItemModel todo = (TodoItemModel)todoListBox.SelectedItem;
                DeleteItem(todo);
            }
        }

        private void todoListBox_DoubleClick(object sender, EventArgs e)
        {
            if (todoListBox.SelectedItem != null)
            {
                TodoItemModel todo = (TodoItemModel)todoListBox.SelectedItem;
                CompleteItem(todo);
            }
        }

        private void todoListBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void todoListBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Down:
                    e.IsInputKey = true;
                    break;

                case Keys.Up:
                    e.IsInputKey = true;
                    break;

                default:
                    break;
            }
        }

        private void todoListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(todoListBox.SelectedItem != null)
            {
                TodoItemModel todo = (TodoItemModel)todoListBox.SelectedItem;

                switch (e.KeyCode)
                {
                    case Keys.Down:
                        MoveItemDown(todo);
                        break;

                    case Keys.Up:
                        MoveItemUp(todo);
                        break;

                    default:
                        break;
                }
            }
        }

        private void todoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
