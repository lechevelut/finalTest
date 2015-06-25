using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalTest
{
    public class Nombres
    {
        private IEnumerable<KeyValuePair<string, int>> keyValuePairs;

        public Nombres(IEnumerable<KeyValuePair<string, int>> keyValuePairs)
        {
            this.keyValuePairs = keyValuePairs;
        }

        public IEnumerable<int> NombresPairs
        {
            get
            {
                return keyValuePairs.Where(x => x.Value%2 == 0).Select(x => x.Value);
            }
        }

        public string TexteNombresImpairs
        {
            get
            {
                return keyValuePairs.Where(x => x.Value % 2 == 1)
                    .OrderBy(x => x.Value)
                    .Select(x => x.Key)
                    .Aggregate((i, j) => i + ", " + j);
            }
        }

        public string PremierNombreDontLeTexteContientPlusDe5Caractères
        {
            get
            {
                return keyValuePairs.Where(x => x.Key.Length > 5).Select(x => x.Key).First();
            }
        }
    }
}
