using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace election
{
    public class CentreElection
    {
        public int id_centre { get; set; }
        public String libelle_centre { get; set; }
        public String adresse_centre { get; set; }
        public IList<Electeur> electeurs { get; set; }
    }
}
