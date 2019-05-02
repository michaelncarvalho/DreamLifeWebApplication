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
using System.Web.Http.Cors;

namespace DreamLifeWeb_api.Controllers
{
   //[EnableCors(origins: "http://localhost/dreamLifeInterface", headers: "*", methods: "*")]
    public class CidadesController : ApiController
    {
        private IRepositorio<Cidade> cidadeRepositorio = new CidadeRepositorio();
        //GET: trips/Cidades
        [HttpGet]
        public List<Cidade> Get()
        {            
            return cidadeRepositorio.SelecionarTodos();
        }


        //GET: trips/Cidades/id
        [HttpGet]
        public Cidade Get(int id)
        {
           
            return cidadeRepositorio.SelecionarPorId(id);
        }

        //POST: trips/Cidades   
        [HttpPost]
        [ActionName("Cidades")]
        public HttpResponseMessage PostCidades(Cidade cidade)
        {

            if (ModelState.IsValid && cidade != null)
            {               
               
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

        //PUT: trips/Cidades 
        [HttpPut]
        [ActionName("Cidades")]
        public HttpResponseMessage PutCidade(Cidade cidade)
        {
            if (ModelState.IsValid && cidade != null)
            {                
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

        [HttpDelete]
        //DELETE: trips/Cidades/id
        public HttpResponseMessage DeleteCidade(int id)
        {
            if (id <= 0 )
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            else
            {
                
                Cidade cidade = new Cidade();
                cidade = cidadeRepositorio.SelecionarPorId(id);
                cidadeRepositorio.Excluir(cidade);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
        }

    }
}

