using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace election
{
    public class Candidat
    {
        public int id_candidat { get; set; }
        public string nom_candidat { get; set; }
        public string prenom_candidat { get; set; }
        public string cin_candidat { get; set; }
        public string Image_candidat { get; set; }
        public Administrateur Administrateur { get; set; }

    }
}
