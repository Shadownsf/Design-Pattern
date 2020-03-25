using System;

namespace AbsctractFactory {
    public class ScooterElectrique : Scooter
    {

        public ScooterElectrique(string modele, string couleur, int puissance) 
        : base(modele, couleur, puissance)
        {
            this._modele = modele;
            this._couleur = couleur;
            this._puissance = puissance;
        }

         public override void afficheCaracteristiques()
         {
             Console.WriteLine($"Je suis un Scooter Electrique de modele {_modele}\nJe suis de couleur {_couleur} et j'ai {_puissance} de puissance !\n");
         }
    }
}