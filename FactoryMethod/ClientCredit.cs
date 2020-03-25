namespace FactoryMethod
{
    public class ClientCredit : Client
    {
        public override Commande créerCommande(double montant)
        {
            return new CommandeCredit(montant);
        }
    }
}