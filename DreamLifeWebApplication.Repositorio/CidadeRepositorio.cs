using DreamLifeWebApplication.Dominio;
using DreamLifeWebApplication.Persistencia.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLifeWebApplication.Repositorio
{
    public class CidadeRepositorio : IRepositorio<Cidade>
    {
        

        public Cidade SelecionarPorId(int id)
        {
            using ( ApplicationDbContext contexto = new ApplicationDbContext())
            {
                return contexto.Cidades.Find(id)
;            }
        }
        public void Inserir(Cidade entidade)
        {
            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
                contexto.Cidades.Add(entidade);
                contexto.SaveChanges();
            }
        }
        public void Atualizar(Cidade entidade)
        {
            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
                contexto.Cidades.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }

        public void Excluir(Cidade entidade)
        {
            using(ApplicationDbContext contexto = new ApplicationDbContext())
            {
                contexto.Cidades.Attach(entidade);
                contexto.Entry(entidade).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        public List<Cidade> SelecionarTodos()
        {
            using (ApplicationDbContext contexto = new ApplicationDbContext())
            {
                return contexto.Cidades.ToList();
            }
        }

    }

}

