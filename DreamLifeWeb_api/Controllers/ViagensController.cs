using DreamLifeWebApplication.Dominio;
using DreamLifeWebApplication.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DreamLifeWeb_api.Controllers
{
    //[EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class ViagensController : ApiController
    {
        private IRepositorio<Viagem> viagemRepositorio = new ViagemRepositorio();

        //GET: trips/Viagens
        [HttpGet]
        public IEnumerable<Viagem> Get()
        {
            IEnumerable<KeyValuePair<string,string>> keyValuePair = Request.GetQueryNameValuePairs();        

           
            if (keyValuePair.Count() == 0)
            {
                return viagemRepositorio.SelecionarTodos();
            }else
            {
                ViagemRepositorio viagemRepositorio = new ViagemRepositorio();
                return viagemRepositorio.SelecionarPorQuery(keyValuePair.First());
            }            
        }

        //GET: trips/Viagens/id
        [HttpGet]
        public Viagem Get(int id)
        {
            return viagemRepositorio.SelecionarPorId(id);
        }

       

        //POST: trips/Viagens 
        [HttpPost]
        [ActionName("Viagens")]
        public HttpResponseMessage PostViagens(Viagem viagem)
        {

            if (ModelState.IsValid && viagem != null)
            {
              
                viagemRepositorio.Inserir(viagem);
                return new HttpResponseMessage(HttpStatusCode.Created);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        //PUT: trips/Viagens
        [HttpPut]
        [ActionName("Viagens")]
        public HttpResponseMessage PutCidade(Viagem viagem)
        {
           
            if (ModelState.IsValid && viagem != null)
            {
                Viagem viagemUpdate = viagemRepositorio.SelecionarPorId(viagem.Id);               
                viagemRepositorio.Atualizar(viagem);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        [HttpDelete]
        //DELETE: trips/Viagens/id
        public HttpResponseMessage Delete(int id)
        {
            if (id <= 0)
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            else
            {

                Viagem viagem = new Viagem();
                viagem = viagemRepositorio.SelecionarPorId(id);
                viagemRepositorio.Excluir(viagem);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
        }
    }
}
