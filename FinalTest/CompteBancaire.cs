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
        private Montant montant = new Montant(0);
        private Montant decouvertAutorise = new Montant(0);

        public CompteBancaire(CompteCréé compteCréé, DépotRéalisé dépotRéalisé)
        {
            numeroCompte = compteCréé.NuméroDeCompte;
            decouvertAutorise.Valeur = compteCréé.AutorisationDeCrédit;
            montant = dépotRéalisé.MontantDepot;
        }

        public CompteBancaire(CompteCréé compteCréé)
        {
            numeroCompte = compteCréé.NuméroDeCompte;
            decouvertAutorise.Valeur = compteCréé.AutorisationDeCrédit;
        }

        public static IEnumerable<IEvenementMetier> Ouvrir(string _numéroDeCompte, int autorisationDeCrédit)
        {
            yield return new CompteCréé(_numéroDeCompte, autorisationDeCrédit);
        }

        public IEnumerable<IEvenementMetier> FaireUnDepot(Montant montantDepot, DateTime dateDepot)
        {
            montant.Valeur += montantDepot.Valeur;
            yield return new DépotRéalisé(numeroCompte, montantDepot, dateDepot);
        }

        public IEnumerable<IEvenementMetier> FaireUnRetrait(Montant montantRetrait, DateTime dateRetrait)
        {
            if ((montant.Valeur - montantRetrait.Valeur)*-1 > decouvertAutorise.Valeur)
            {
                throw new RetraitNonAutorisé();
            }
            else
            {
                montant.Valeur -= montantRetrait.Valeur;
                yield return new RetraitRéalisé(numeroCompte, montantRetrait, dateRetrait);
                if (montant.Valeur < 0)
                {
                    yield return new BalanceNégativeDétectée(numeroCompte, new Montant(montant.Valeur*-1), dateRetrait);
                }
            }

        }
    }

    public class RetraitNonAutorisé : Exception
    {
        
    }
}
