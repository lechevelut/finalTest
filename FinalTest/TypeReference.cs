using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public class TypeReference
    {

        private int valeur;

        public TypeReference(int i)
        {
            this.valeur = i;
        }

        public override bool Equals(Object obj)
        {
            TypeReference typeReferenceObj = obj as TypeReference;
            if (typeReferenceObj == null)
                return false;
            else
                return valeur.Equals(typeReferenceObj.valeur);
        }

    }
}
