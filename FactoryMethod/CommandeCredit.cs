using System;

namespace FactoryMethod
{
    internal class CommandeCredit : Commande
    {
        public CommandeCredit(double montant) : base(montant)
        {
            this._montant = montant;
        }

        public override void paye()
        {
            Console.WriteLine($"Le paiement de la commande au credit de : {_montant} est effectué.");
        }

        public override bool valide()
        {
            return (_montant >= 1000.0) && (_montant <= 5000.0);
        }
    }
}