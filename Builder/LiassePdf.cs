using System;
using System.Collections.Generic;

namespace Builder
{
    public class LiassePdf : Liasse
    {

        public LiassePdf() : base()
        {
            this.contenu = new List<string>();
        }

        public override void ajouteDocument(string document)
        {
            if (!document.Contains("<Pdf>"))
                throw new Exception("Bad type of document. '<Pdf>'");

            this.contenu.Add(document);
        }

        public override void imprime()
        {
            Console.WriteLine("START OF DOCUMENT");

            foreach(string doc in contenu)
            {
                Console.WriteLine(doc);
            }

            Console.WriteLine("END OF DOCUMENT");
        }
    }
}