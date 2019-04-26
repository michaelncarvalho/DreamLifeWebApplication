using DreamLifeWebApplication.Dominio;
using DreamLifeWebApplication.Persistencia.EF.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLifeWebApplication.Persistencia.EF
{
    public class ApplicationDbContext : DbContext
    {
      

        public ApplicationDbContext() : base("ViagensContext")
        {
            //Database.SetInitializer<ApplicationDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.Configuration.LazyLoadingEnabled = false;
            //modelBuilder.HasDefaultSchema("mytrips").Entity<Cidade>().HasKey(c => c.Id);

            //modelBuilder.Entity<Hotel>().HasRequired(c => c.Cidade);

            //modelBuilder.HasDefaultSchema("mytrips")
            modelBuilder
                .HasDefaultSchema("mytrips")
                .Entity<Hotel>()
                .HasRequired(h => h.Cidade);



            modelBuilder
                .HasDefaultSchema("mytrips")
                .Entity<Viagem>()
                .HasRequired(v => v.Hotel);
            
            
         
        }

        public static ApplicationDbContext Create() => new ApplicationDbContext();

        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Hotel> Hoteis { get; set; }
        public DbSet<Viagem> Viagens { get; set; }
    }
}
