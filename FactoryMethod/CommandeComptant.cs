using System;

namespace FactoryMethod
{
    public class CommandeComptant : Commande
    {
        public CommandeComptant(double montant) : base(montant)
        {
            this._montant = montant;
        }

        public override void paye()
        {
            Console.WriteLine($"Le paiement de la commande au comptant de : {_montant} est effectué.");
        }

        public override bool valide()
        {
            return true;
        }
    }
}