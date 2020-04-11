namespace Composition
{
    public class Task : TodoList
    {
        public Task(string title) : base(title)
        {
        }

        public override string getHtml(int tabulation = 0)
        {
            return _title;
        }
    }
}