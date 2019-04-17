using DreamLifeWebApplication.Dominio;
using DreamLifeWebApplication.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DreamLifeWebApplication.Controllers
{
    public class HomeController : Controller
    {


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {

            // Teste Selecionar Todos
            //IRepositorio<Cidade> repositorioCidades = new CidadeRepositorio();
            //List<Cidade> cidades = repositorioCidades.SelecionarTodos();

           
            IRepositorio<Cidade> repositorioCidades = new CidadeRepositorio();
            Cidade cidadeExcluir = repositorioCidades.SelecionarPorId(1);
            repositorioCidades.Excluir(cidadeExcluir);

            return View();
        }
        
    }
}