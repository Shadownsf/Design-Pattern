using System;

namespace AbsctractFactory 
{
    public class FabriqueVehiculeElectricite : IFabriqueVehicule
    {
        public Automobile creeAutomobile(string modele, string couleur, int puissance, double espace)
        {
            Automobile automobile = new AutomobileElectrique(modele, couleur, puissance, espace);

            return automobile;
        }

        public Scooter creeScooter(string modele, string couleur, int puissance)
        {
            Scooter scooter = new ScooterElectrique(modele, couleur, puissance);

            return scooter;
        }
    }
}