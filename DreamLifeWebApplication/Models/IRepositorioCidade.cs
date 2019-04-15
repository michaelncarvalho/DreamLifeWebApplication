using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DreamLifeWebApplication.Models
{
    public interface IRepositorioCidade
    {
        Cidade Salvar(Cidade cidade);
        bool Excluir(Cidade cidade);
        Cidade GetCidade(int id);
        Cidade[] GetCidades();
        Cidade[] GetCidades(Func<Cidade, bool> expressao);
    }
}