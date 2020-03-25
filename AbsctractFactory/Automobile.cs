using System;

namespace AbsctractFactory 
{

    public abstract class Automobile 
    {
         protected string _modele;
        protected string _couleur;
        protected int _puissance;
        protected double _espace;

        public Automobile(string modele, string couleur, int puissance, double espace)
        {
            this._modele = modele;
            this._couleur = couleur;
            this._puissance = puissance;
            this._espace = espace;
        }

         public abstract void afficheCaracteristiques();  
    }
}