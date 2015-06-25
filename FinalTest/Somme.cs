using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public class Somme : IOperation
    {
        public Somme()
        {
        }

        public bool PeutCalculer(string operation)
        {
            return operation.Contains("+");
        }

        public int Calculer(string operation)
        {
            int i = int.Parse(operation.Split('+')[0]);
            int j = int.Parse(operation.Split('+')[1]);
            return i+j;
        }
    }
}
