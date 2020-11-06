using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformToDo
{
    public class TodoItemModel
    {
        public int positionNumber { get; set; }

        public string TodoText { get; set; }

        public bool IsComplete { get; set; } = false;
    }
}
