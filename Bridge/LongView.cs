using System;

namespace Bridge
{
    internal class LongView : View
    {
        public LongView(IRessource ressource) : base(ressource)
        {
        }

        public override void show()
        {
            Console.WriteLine(_ressource.getTitle());
            Console.WriteLine(_ressource.getImage());
            Console.WriteLine(_ressource.getSnippet());
        }
    }
}