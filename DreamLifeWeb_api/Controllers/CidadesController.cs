using DreamLifeWebApplication.Dominio;
using DreamLifeWebApplication.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace DreamLifeWeb_api.Controllers
{
    public class CidadesController : ApiController
    {
        //GET: trips/Cidades
        [HttpGet]
        public List<Cidade> Get()
        {
            IRepositorio<Cidade> cidadeRepositorio = new CidadeRepositorio();
            return cidadeRepositorio.SelecionarTodos();
        }

        //GET: trips/Cidades/id
        [HttpGet]
        public Cidade Get(int id)
        {
            IRepositorio<Cidade> cidadeRepositorio = new CidadeRepositorio();
            return cidadeRepositorio.SelecionarPorId(id);
        }

        //POST: trips/Cidades   
        [HttpPost]
        [ActionName("Cidades")]
        public HttpResponseMessage PostCidades(Cidade cidade)
        {

            if (ModelState.IsValid && cidade != null)
            {               
                IRepositorio<Cidade> cidadeRepositorio = new CidadeRepositorio();
                cidadeRepositorio.Inserir(new Cidade()
                {
                    Nome = cidade.Nome,
                    Pais = cidade.Pais
                });
                return new HttpResponseMessage(HttpStatusCode.Created);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        public HttpResponseMessage PutCidade(Cidade cidade)
        {
            if (ModelState.IsValid && cidade != null)
            {
                IRepositorio<Cidade> cidadeRepositorio = new CidadeRepositorio();
                Cidade cidadeUpdate = cidadeRepositorio.SelecionarPorId(cidade.Id);
                cidadeUpdate.Nome = cidade.Nome;
                cidadeUpdate.Pais = cidade.Pais;
                cidadeRepositorio.Atualizar(cidadeUpdate);


                return new HttpResponseMessage(HttpStatusCode.OK);
            }else
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }
    }
}

