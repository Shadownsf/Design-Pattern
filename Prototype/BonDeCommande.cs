using System;

namespace Prototype
{
    public class BonDeCommande : Document
    {
        private string _contenu;

        public BonDeCommande()
        {
            _contenu = "";
        }
        public override void affiche()
        {
            Console.WriteLine($"###############\nBON DE COMMANDE DE {_contenu}.\n###############\n");
        }

        public override Document clone()
        {
            return (Document)this.MemberwiseClone();
        }

        public override void remplir(string information)
        {
            _contenu = information;
        }
    }
}