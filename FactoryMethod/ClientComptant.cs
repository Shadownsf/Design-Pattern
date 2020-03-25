namespace FactoryMethod
{
    public class ClientComptant : Client
    {
        public override Commande créerCommande(double montant)
        {
            return new CommandeComptant(montant);
        }
    }
}