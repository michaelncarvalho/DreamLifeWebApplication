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
            throw new NotImplementedException();
        }

        public void Excluir(Cidade entidade)
        {
            throw new NotImplementedException();
        }

       

       
    }

}

