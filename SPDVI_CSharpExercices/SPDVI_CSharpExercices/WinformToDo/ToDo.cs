using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformToDo
{
    public partial class ToDo : Form
    {
        BindingList<TodoItemModel> todoList = new BindingList<TodoItemModel>();

        public ToDo()
        {
            InitializeComponent();
        }

        private void AddToDo(string todoText)
        {
            TodoItemModel todo = new TodoItemModel
            {
                positionNumber = todoList.Count + 1,
                TodoText = todoText
            };
            todoList.Add(todo);
        }

        private void ReOrderToDo()
        {
            for (int i = 0; i < todoList.Count; i++)
            {
                todoList[i].positionNumber = (i + 1);
            }
        }

        private void RemoveItem(TodoItemModel todo)
        {
            todoList.Remove(todo);
            ReOrderToDo();
        } 
    }
}
