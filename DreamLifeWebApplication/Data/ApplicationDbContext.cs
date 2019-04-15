using DreamLifeWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DreamLifeWebApplication.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("ViagensContext")
        {
        }

        public static ApplicationDbContext Create() => new ApplicationDbContext();        

        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Viagem> Viagem { get; set; }
    }
}