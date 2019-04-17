using DreamLifeWebApplication.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLifeWebApplication.Persistencia.EF.Context
{
    public class ApplicationDbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            base.Seed(context);
            //Seeding Cidades
            context.Cidades.Add(new Cidade
            {
                Nome = "Lavras",
                Pais = "Brasil",
            });
            context.Cidades.Add(new Cidade
            {
                Nome = "Sete Lagoas",
                Pais = "Brasil",
            });
            context.Cidades.Add(new Cidade
            {
                Nome = "São Carlos",
                Pais = "Brasil",
            });
            context.SaveChanges();
            //Seeding Hoteis
            context.Hoteis.Add(new Hotel
            {
                Nome = "Hotel Ouro Lavras",
                CidadeId = context.Cidades.FirstOrDefault(c => c.Nome == "Lavras").Id,
                Preco = 123.55,
                Classificacao = 3,
                Descricao = "Hotel modesto no centro com quartos despretensiosos, além de café da manhã e estacionamento gratuitos",              
                
            });
            context.Hoteis.Add(new Hotel
            {
                Nome = "Minas Hotel",
                CidadeId = context.Cidades.FirstOrDefault(c => c.Nome == "Lavras").Id,
                Descricao = "Ótimas localizações. Ofertas em acomodação exclusivas durante períodos de grande demanda",               

            });
            context.SaveChanges();
            //Seeding Viagens
            context.Viagens.Add(new Viagem
            {
                HotelId = context.Hoteis.FirstOrDefault(h => h.Nome == "Hotel Ouro Lavras").Id,
                Data = DateTime.Now,
                QuantidadePessoas = 2,
                ModalidadeViagem = "First"            
            });
            context.Viagens.Add(new Viagem
            {
                HotelId = context.Hoteis.FirstOrDefault(h => h.Nome == "Minas Hotel").Id,
                Data = DateTime.Now,
                QuantidadePessoas = 2,
                ModalidadeViagem = "Business"
            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
