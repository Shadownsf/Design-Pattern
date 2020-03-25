
using System;
namespace FactoryMethod
{
    public abstract class Client
    {
        public void nouvelleCommande(double montant)
        {
            Commande command = créerCommande(montant);

            if(command.valide())
                command.paye();
        }

        public abstract Commande créerCommande(double montant);
    }
}