using System;

namespace Builder 
{
    public class ConstructeurLiasseVehiculeHtml : ConstructeurLiasseVehicule
    {
        public ConstructeurLiasseVehiculeHtml() : base()
        {
            liasse = new LiasseHtml();
        }

        public override void construitBonDeCommande(string nomDemandeur)
        {
            string document = string.Format($"<Html>\n Bon de commande\n Client {nomDemandeur}\n<Html>\n");
            liasse.ajouteDocument(document);
        }

        public override void construitDemandeImmatriculation(string nomDemandeur)
        {
            string document = string.Format($"<Html>\n Demande d'immatriculation\n Client {nomDemandeur}\n<Html>\n");
            liasse.ajouteDocument(document);
        }

        public override Liasse Resultat()
        {
            return liasse;
        }
    }
}