using System;

namespace AbsctractFactory 
{
    public class FabriqueVehiculeEssence : IFabriqueVehicule
    {
        public Automobile creeAutomobile(string modele, string couleur, int puissance, double espace)
        {
            Automobile automobile = new AutomobileEssence(modele, couleur, puissance, espace);

            return automobile;
        }

        public Scooter creeScooter(string modele, string couleur, int puissance)
        {
            Scooter scooter = new ScooterEssence(modele, couleur, puissance);

            return scooter;
        }
    }
}