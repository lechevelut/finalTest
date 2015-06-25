using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTest
{
    public class CompteBancaire
    {
        private string numeroCompte;

        public CompteBancaire(CompteCréé compteCréé)
        {
            numeroCompte = compteCréé.NuméroDeCompte;
        }


        public static IEnumerable<IEvenementMetier> Ouvrir(string _numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(_numéroDeCompte, autorisationDeCrédit);
        }

        public IEnumerable<IEvenementMetier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            yield return new DépotRéalisé(numeroCompte, montantDepot, dateDepot);
        }
    }
}
