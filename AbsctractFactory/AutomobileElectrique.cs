using System;

namespace AbsctractFactory {
    public class AutomobileElectrique : Automobile
    {

        public AutomobileElectrique(string modele, string couleur, int puissance, double espace) 
        : base(modele, couleur, puissance, espace)
        {
            this._modele = modele;
            this._couleur = couleur;
            this._puissance = puissance;
            this._espace = espace;
        }

         public override void afficheCaracteristiques()
         {
             Console.WriteLine($"Je suis un Automobile Electrique de modele {_modele}\nJe suis de couleur {_couleur} et j'ai {_puissance} de puissance !\n j'ai {_espace} d'espace!\n");
         }
    }
}