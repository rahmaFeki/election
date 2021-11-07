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
        public DbSet<Administrateur> Administrateurs { get; set; }
        public DbSet<CentreElection> CentreElections { get; set; }
        public DbSet<Electeur> Electeurs { get; set; }


        //NB:Configuration a modifier pour chaqu'un entre nous !!!
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=RAHMA\SQLEXPRESS;Database=ELECTIONDB;Trusted_Connection=True;");
        }





        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidat>()
                        .HasMany<Electeur>(c => c.Electeurs)
                        .WithOne(e => e.Candidat)
                        .OnDelete(DeleteBehavior.SetNull);

        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administrateur>()
                .HasOne(a => a.CentreElection)
                .WithOne(b => b.Administrateur)
                .HasForeignKey<CentreElection>(b => b.AdministrateurId);
        }
    }
}
