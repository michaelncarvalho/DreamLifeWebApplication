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
    public class HotelsController : ApiController
    {
        private IRepositorio<Hotel> hotelRepositorio = new HotelRepositorio();
        //GET: trips/Hotels
        [HttpGet]
        public IEnumerable<Hotel> Get()
        {
            IEnumerable<KeyValuePair<string, string>> keyValuePair = Request.GetQueryNameValuePairs();

            if (keyValuePair.Count() == 0)
            {
                return hotelRepositorio.SelecionarTodos();
            }
            else
            {
                HotelRepositorio hotelRepositorio = new HotelRepositorio();
                return hotelRepositorio.SelecionarPorQuery(keyValuePair.First());
            }
        }


        //GET: trips/Hotels/id
        [HttpGet]
        public Hotel Get(int id)
        {
            return hotelRepositorio.SelecionarPorId(id);
        }
       

        //POST: trips/Hotels  
        [HttpPost]
        [ActionName("Hotels")]
        public HttpResponseMessage PostHotels(Hotel hotel)
        {

            if (ModelState.IsValid && hotel != null)
            {
                IRepositorio<Cidade> repositorioCidade = new CidadeRepositorio();
                Cidade cidade = repositorioCidade.SelecionarPorId(hotel.CidadeId);
                hotelRepositorio.Inserir(new Hotel()
                {
                    Nome = hotel.Nome,
                    Preco = hotel.Preco,
                    Classificacao = hotel.Classificacao,
                    Descricao = hotel.Descricao,
                    CidadeId = hotel.CidadeId,
                    Cidade = cidade                    
                });
                return new HttpResponseMessage(HttpStatusCode.Created);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        //PUT: trips/Hotels 
        [HttpPut]
        [ActionName("Hotels")]
        public HttpResponseMessage PutCidade(Hotel hotel)
        {
            IRepositorio<Cidade> repositorioCidade = new CidadeRepositorio();
            Cidade cidade = repositorioCidade.SelecionarPorId(hotel.CidadeId);
            if (ModelState.IsValid && hotel != null)
            {
                Hotel hotelUpdate = hotelRepositorio.SelecionarPorId(hotel.Id);
                hotelUpdate.Nome = hotel.Nome;
                hotelUpdate.Preco = hotel.Preco;
                hotelUpdate.Descricao = hotel.Descricao;
                hotelUpdate.CidadeId = hotel.CidadeId;
                hotelUpdate.Cidade = cidade;                
                hotelRepositorio.Atualizar(hotelUpdate);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        [HttpDelete]
        //DELETE: trips/Hotels/id
        public HttpResponseMessage Delete(int id)
        {
            if (id <= 0)
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            else
            {

                Hotel hotel = new Hotel();
                hotel = hotelRepositorio.SelecionarPorId(id);
               hotelRepositorio.Excluir(hotel);
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
        }

    }
}
