using System;

namespace Builder
{
    public abstract class  ConstructeurLiasseVehicule
    {
        protected Liasse liasse;
        public abstract void construitBonDeCommande(string nomDemandeur);
        public abstract void construitDemandeImmatriculation(string nomDemandeur);
        public abstract Liasse Resultat();
    }
}
