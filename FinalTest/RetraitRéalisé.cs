using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public struct RetraitRéalisé : IEvenementMetier
    {
        private string numeroCompte;
        private Montant montant;
        private DateTime dateRetrait;

        public RetraitRéalisé(string numéroDeCompte, Montant montantRetrait, DateTime dateRetrait)
        {
            this.numeroCompte = numéroDeCompte;
            this.montant = montantRetrait;
            this.dateRetrait = dateRetrait;
        }
    }
}
