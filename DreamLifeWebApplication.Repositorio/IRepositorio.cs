using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamLifeWebApplication.Repositorio
{
    public interface IRepositorio<TDominio>
    {
        TDominio SelecionarPorId(int id);
        void Inserir (TDominio entidade);
        void Atualizar(TDominio entidade);
        void Excluir(TDominio entidade);
        List<TDominio> SelecionarTodos();
    }
}
