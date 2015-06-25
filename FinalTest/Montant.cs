using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public struct Montant
    {

        private int valeur;

        public Montant(int valeur)
        {
            this.valeur = valeur;
        }

        public int Valeur
        {
            get { return valeur; }
            set { valeur = value; }
        }
    }
}
