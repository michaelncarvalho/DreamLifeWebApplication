using DreamLifeWebApplication.Dominio;
using DreamLifeWebApplication.Persistencia.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLifeWebApplication.Repositorio
{
    public class HotelRepositorio : IRepositorio<Hotel>
    {
               

        public void Inserir(Hotel entidade)
        {
            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
                //Cidade cidade = contexto.Cidades.Find(entidade.CidadeId);
                //entidade.Cidade = cidade;
                contexto.Hoteis.Add(entidade);
                contexto.SaveChanges();
            }
        }
        public void Atualizar(Hotel entidade)
        {
            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
                Cidade cidade = contexto.Cidades.Find(entidade.CidadeId);
                entidade.Cidade = cidade;
                contexto.Hoteis.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public IEnumerable<Hotel> SelecionarPorQuery(KeyValuePair<string, string> keyValuePair)
        {
            using (ApplicationDbContext contexto = new ApplicationDbContext())

            {
                int cidadeId = Convert.ToInt32(keyValuePair.Value);
                return contexto.Hoteis
                    .Include("Cidade")
                    .Where(v => keyValuePair.Key == "CidadeId" && cidadeId == v.CidadeId)
                    .ToList();
            }
        }
        public void Excluir(Hotel entidade)
        {
            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
                
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        public Hotel SelecionarPorId(int id)
        {
            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
                var result = contexto.Hoteis.Find(id);
                contexto.Entry(result).Reference("Cidade").Load();
                return result;
;
            }
        }

        public List<Hotel> SelecionarTodos()
        {
            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
                return contexto.Hoteis.Include("Cidade").ToList();
            }
        }        

       
    }
}
