using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public struct BalanceNégativeDétectée : IEvenementMetier
    {

        private string numeroCompte;
        private Montant montant;
        private DateTime dateRetrait;

        public BalanceNégativeDétectée(string numeroCompte, Montant montant, DateTime dateRetrait)
        {
            this.numeroCompte = numeroCompte;
            this.montant = montant;
            this.dateRetrait = dateRetrait;
        }
    }
}
