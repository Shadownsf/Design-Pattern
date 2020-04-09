namespace Prototype
{
    public abstract class Document
    {
        public abstract void remplir(string information);
        public abstract void affiche();
        public abstract Document clone();
    }
}