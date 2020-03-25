using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client;
            Console.WriteLine("Voulez-vous payez Comptant (1) ou à Crédit (2) :");
            string choix = Console.ReadLine();
            if (choix == "1")
            {
                client = new ClientComptant();
            }
            else
            {
                client = new ClientCredit();
            }

            client.nouvelleCommande(2000.0);
            client.nouvelleCommande(10000.0);
        }
    }
}