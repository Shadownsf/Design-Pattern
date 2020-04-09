namespace Bridge
{
    public abstract class View
    {
        protected IRessource _ressource;

        public View(IRessource ressource)
        {
            _ressource = ressource;
        }

        public abstract void show();
    }
}