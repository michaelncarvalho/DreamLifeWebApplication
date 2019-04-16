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
            Database.SetInitializer<ApplicationDbContext>(null);
        }

        public static ApplicationDbContext Create() => new ApplicationDbContext();

        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Hotel> Hoteis { get; set; }
        public DbSet<Viagem> Viagens { get; set; }
    }
}
