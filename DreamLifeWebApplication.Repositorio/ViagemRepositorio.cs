using DreamLifeWebApplication.Dominio;
using DreamLifeWebApplication.Persistencia.EF;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLifeWebApplication.Repositorio
{
    public class ViagemRepositorio : IRepositorio<Viagem>
    {


        public void Atualizar(Viagem entidade)
        {
            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
                Hotel hotel = contexto.Hoteis.Find(entidade.HotelId);
                entidade.Hotel = hotel;
                contexto.Viagens.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Excluir(Viagem entidade)
        {
            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
                Hotel hotel = contexto.Hoteis.Find(entidade.HotelId);
                contexto.Viagens.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        public void Inserir(Viagem entidade)
        {
            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
                Hotel hotel = contexto.Hoteis.Find(entidade.HotelId);
                entidade.Hotel = hotel;
                contexto.Viagens.Add(entidade);
                contexto.SaveChanges();
            }
        }

        public Viagem SelecionarPorId(int id)
        {
            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {

                var result = contexto.Viagens.Find(id);
                contexto.Entry(result).Reference("Hotel").Load();
                return result;                
            }
        }

        /*public List<Viagem> SelecionarTodosPorData(DateTime data)
        {
            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
                return contexto.Viagens.Include("Hotel").Where(v => v.Data == data ).ToList();
            }
        }*/

        public IEnumerable<Viagem> SelecionarPorQuery(KeyValuePair<string, string> keyValuePair)
        {
            using (ApplicationDbContext contexto = new ApplicationDbContext())

            {
                int cidadeId = Convert.ToInt32(keyValuePair.Value);
                return contexto.Viagens.Include("Hotel")
                    .Where(v => keyValuePair.Key == "Hotel.CidadeId" && cidadeId == v.Hotel.CidadeId)
                    .ToList();


                /*return contexto.Viagens.Include("Hotel")
                    .Where(h => keyValuePair.Key == "data" && data == h.Data)
                    .GroupBy(v => v.HotelId)
                    .Select( x => new { }  ).ToList(); 
                //int value = Convert.ToInt32(keyValuePair.Value);
                //return contexto.Viagens.Include("Hotel").Where(h => keyValuePair.Key == "HotelId" && value == h.HotelId).Distinct().ToList(); */
            }
        }

        public List<Viagem> SelecionarTodos()
        {
            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
                return contexto.Viagens.Include("Hotel").ToList();
            }
        }
    }
}
