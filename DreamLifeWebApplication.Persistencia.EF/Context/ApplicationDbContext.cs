using DreamLifeWebApplication.Dominio;
using System.Data.Entity;

namespace DreamLifeWebApplication.Persistencia.EF
{
    public class ApplicationDbContext : DbContext
    {
      

        public ApplicationDbContext() : base("ViagensContext")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.Configuration.LazyLoadingEnabled = false;
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
