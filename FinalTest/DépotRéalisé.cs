using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public struct DépotRéalisé : IEvenementMetier
    {
        private string numeroCompte;
        private Montant montantDepot;
        private DateTime dateDepot;

        public DépotRéalisé(string numéroDeCompte, Montant montantDepot, DateTime dateDepot)
        {
            this.numeroCompte = numéroDeCompte;
            this.montantDepot = montantDepot;
            this.dateDepot = dateDepot;
        }
    }
}
