using System;

namespace AbsctractFactory
{
    public abstract class Scooter
    {
        protected string _modele;
        protected string _couleur;
        protected int _puissance;

        public Scooter(string modele, string couleur, int puissance)
        {
            this._modele = modele;
            this._couleur = couleur;
            this._puissance = puissance;
        }

         public abstract void afficheCaracteristiques();
    }    
}