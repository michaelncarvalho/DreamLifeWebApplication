﻿using DreamLifeWebApplication.Dominio;
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
            IRepositorio<Cidade> repositorioCidades = new CidadeRepositorio();
            List<Cidade> cidades = repositorioCidades.SelecionarTodos();

            foreach (Cidade cidade in cidades)
            {
                Console.WriteLine("{0} , {1} - {2}, {3}", cidade.Id, cidade.Nome, cidade.Estado, cidade.Pais);
            }

            return View();
        }
        
    }
}