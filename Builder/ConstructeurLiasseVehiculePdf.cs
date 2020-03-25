using System;

namespace Builder
{
    public class ConstructeurLiasseVehiculePdf : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculePdf() : base()
        {
            liasse = new LiassePdf();
        }
        public override void construitBonDeCommande(string nomDemandeur)
        {
            string document = string.Format($"<Pdf>\n Bon de commande\n Client {nomDemandeur}\n<Pdf>\n");
            liasse.ajouteDocument(document);
        }

        public override void construitDemandeImmatriculation(string nomDemandeur)
        {
            string document = string.Format($"<Pdf>\n Demande d'immatriculation\n Client {nomDemandeur}\n<Pdf>\n");
            liasse.ajouteDocument(document);
        }

        public override Liasse Resultat()
        {
            return liasse;
        }
    }
}