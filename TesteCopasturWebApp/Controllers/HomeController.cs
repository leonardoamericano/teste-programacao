using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteCopasturWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Resumo Profissional";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Resultado da questão 6";

            var servico = new ServicoGeral("Leonardo", "Americano");

            //Questão 6
            ViewBag.MessageSKY = servico.palavraTriangulo("SKY");
            ViewBag.MessageASDF = servico.palavraTriangulo("ASDF");

            return View();
        }
    }
}