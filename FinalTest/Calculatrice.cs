using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public class Calculatrice
    {
        private Somme somme;
        private Multiplication multiplication;

        public Calculatrice(IOperation[] operation)
        {
            this.somme = (Somme) operation[1];
            this.multiplication = (Multiplication) operation[0];
        }

        public int Calculer (string operation)
        {
            if (somme.PeutCalculer(operation))
                return somme.Calculer(operation);
            else
                return multiplication.Calculer(operation);
        }

    }
}
