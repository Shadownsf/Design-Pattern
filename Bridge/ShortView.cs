using System;

namespace Bridge
{
    public class ShortView : View
    {
        public ShortView(IRessource ressource) : base(ressource)
        {
        }

        public override void show()
        {
            Console.WriteLine(_ressource.getTitle());
            Console.WriteLine(_ressource.getSnippet());
        }
    }
}