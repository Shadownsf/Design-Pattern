using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            LiasseVierge liasseVierge = LiasseVierge.Instance();
            liasseVierge.ajoute(new BonDeCommande());
            liasseVierge.ajoute(new CertificatCession());

            var demandeImmatriculation = new DemandeImmatriculation(); 
            liasseVierge.ajoute(demandeImmatriculation);

            // création d’une nouvelle liasse pour deux clients
            LiasseClient liasseClient1 = new LiasseClient("Martin");
            LiasseClient liasseClient2 = new LiasseClient("Durant");
            liasseClient1.affiche();
            liasseClient2.affiche();

            // suppression d'un Document dans les liasses
            liasseVierge.retire(demandeImmatriculation);
            LiasseClient liasseClient3 = new LiasseClient("Charle");
            LiasseClient liasseClient4 = new LiasseClient("Benoit");
            liasseClient3.affiche();
            liasseClient4.affiche();
        }
    }
}
