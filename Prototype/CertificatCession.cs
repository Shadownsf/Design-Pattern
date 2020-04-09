using System;

namespace Prototype
{
    public class CertificatCession : Document
    {
        private string _contenu;

        public CertificatCession()
        {
            _contenu = "";
        }
        public override void affiche()
        {
            Console.WriteLine($"###############\nCERTIFICAT DE CESSION DE {_contenu}.\n###############\n");
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