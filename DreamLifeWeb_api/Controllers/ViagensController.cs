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
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
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

        /*//GET: trips/Viagens?data={data}
        [HttpGet]
        public List<Viagem> Get(DateTime data)
        {
            ViagemRepositorio viagemRepositorio = new ViagemRepositorio();
            return viagemRepositorio.SelecionarTodosPorData(data);
        } */

        //POST: trips/Viagens 
        [HttpPost]
        [ActionName("Viagens")]
        public HttpResponseMessage PostViagens(Viagem viagem)
        {

            if (ModelState.IsValid && viagem != null)
            {
                /*IRepositorio<Hotel> repositorioCidade = new HotelRepositorio();
                Hotel hotel = repositorioCidade.SelecionarPorId(viagem.HotelId);
                viagemRepositorio.Inserir(new Viagem()
                {
                   HotelId = viagem.HotelId,
                   Data = DateTime.Now,
                   QuantidadePessoas = viagem.QuantidadePessoas,
                   ModalidadeViagem = viagem.ModalidadeViagem,
                   Hotel = hotel
                }); */
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
            //IRepositorio<Hotel> repositorioCidade = new HotelRepositorio();
            //Hotel hotel = repositorioCidade.SelecionarPorId(viagem.HotelId);
            if (ModelState.IsValid && viagem != null)
            {
                Viagem viagemUpdate = viagemRepositorio.SelecionarPorId(viagem.Id);
                //viagemUpdate.HotelId = viagem.HotelId;
               // viagemUpdate.Hotel = hotel;
               // viagemUpdate.ModalidadeViagem = viagem.ModalidadeViagem;
               // viagemUpdate.QuantidadePessoas = viagem.QuantidadePessoas;
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
