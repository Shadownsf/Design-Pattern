using System;

namespace Builder
{
    internal class Vendeur
    {
        private ConstructeurLiasseVehicule constructeur;

        public Vendeur(ConstructeurLiasseVehicule constructeur)
        {
            this.constructeur = constructeur;
        }

        internal Liasse construit(string nomDemandeur)
        {
            constructeur.construitBonDeCommande(nomDemandeur);
            constructeur.construitDemandeImmatriculation(nomDemandeur);
            Liasse liasse = constructeur.Resultat();

            return liasse;
        }
    }
}