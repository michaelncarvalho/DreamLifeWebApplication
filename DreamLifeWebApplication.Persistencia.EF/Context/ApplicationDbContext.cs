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

            modelBuilder
                .HasDefaultSchema("mytrips")
                .Entity<Hotel>()
                .HasRequired(h => h.Cidade)
                .WithMany(h => h.Hotels)
                .HasForeignKey(fk => fk.CidadeId)
                .WillCascadeOnDelete(false);

            modelBuilder
                .HasDefaultSchema("mytrips")
                .Entity<Viagem>()
                .HasRequired(v => v.Hotel)
                .WithMany(v => v.Viagens)
                .HasForeignKey(fk => fk.HotelId)
                .WillCascadeOnDelete(false);                
         
        }

        public static ApplicationDbContext Create() => new ApplicationDbContext();

        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Hotel> Hoteis { get; set; }
        public DbSet<Viagem> Viagens { get; set; }
    }
}
