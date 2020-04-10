using System;

namespace Composition
{
    public abstract class TodoList
    {
        protected string _title;

        public TodoList(string title)
        {
            _title = title;
        }

        public abstract string getHtml(int tabulation = 0);
    }
}