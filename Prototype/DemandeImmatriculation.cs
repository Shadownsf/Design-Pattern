using System;

namespace Prototype
{
    public class DemandeImmatriculation : Document
    {
        private string _contenu;
        public DemandeImmatriculation()
        {
            _contenu = "";
        }

        public override void affiche()
        {
            Console.WriteLine($"###############\nDEMANDE D'IMMATRICULATION DE {_contenu}.\n###############\n");
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