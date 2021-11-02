using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace election
{
    class ElectionContext : DbContext
    {
        public DbSet<Candidat> Candidats { get; set; }
    }
}
