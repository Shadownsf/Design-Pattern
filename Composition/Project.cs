using System.Collections.Generic;
using System.Text;

namespace Composition
{
    internal class Project : TodoList
    {
        private TodoList[] _todos;
        private bool _check;
        public Project(string title, TodoList[] todos) : base(title)
        {
            _todos = todos;
            _check = false;
        }

        public override string getHtml(int tabulation = 0)
        {
            string html = $"{getChecked()} {_title.ToUpper()}\n";

            foreach (var todo in _todos)
            {       
                html += $"{getChecked()} {todo.getHtml(++tabulation)}\n";
            }

            return html;
        }

        private string getChecked()
        {
            return _check ? "✅" : "❌";
        }
    }
}