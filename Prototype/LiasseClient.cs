using System;
using System.Collections.Generic;

namespace Prototype
{
    public class LiasseClient : Liasse
    {
        public LiasseClient(string information) : base()
        {
            _documents = new List<Document>();
            
            var liasseVierge = LiasseVierge.Instance();

            getAllClone(liasseVierge._documents);
            remplir(information);
        }

        void getAllClone(IList<Document> documents)
        {
            foreach (var doc in documents)
            {
                _documents.Add(doc.clone());
            }
        }

        public void affiche()
        {
            foreach(var doc in _documents)
            {
                doc.affiche();
            }
        }

        public void remplir(string information)
        {
            foreach(var doc in _documents)
            {
                doc.remplir(information);
            }
        }
    }
}