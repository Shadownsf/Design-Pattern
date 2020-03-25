namespace FactoryMethod
{
    public abstract class Commande
    {
        protected double _montant;

        public Commande(double montant)
        {
            this._montant = montant;
        }
        
        public abstract bool valide();
        public abstract void paye();
    }
}