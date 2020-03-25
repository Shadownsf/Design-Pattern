using System;
using System.Collections.Generic;

namespace Builder
{
    public abstract class Liasse
    {
        protected List<string> contenu;
        public abstract void ajouteDocument(string document);
        public abstract void imprime();
    }
}