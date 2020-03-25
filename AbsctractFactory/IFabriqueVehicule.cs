using System.Collections.Generic;

namespace AbsctractFactory 
{
    public interface IFabriqueVehicule
    {
        public Automobile creeAutomobile(string modele, string couleur, int puissance, double espace);
        public Scooter creeScooter(string modele, string couleur, int puissance);
    } 
}
