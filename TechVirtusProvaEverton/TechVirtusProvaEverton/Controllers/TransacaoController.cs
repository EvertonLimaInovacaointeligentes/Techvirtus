using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TechVirtusProvaEverton.Controllers
{
    public class TransacaoController : Controller
    {
        // GET: Transacao
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Consultar()
        {
            return View("Consultar","Transacao");
        }
        public ActionResult Consulta()
        {
            return View();
        }
        public ActionResult Pendencia()
        {
            return View();
        }
        public ActionResult Analisar()
        {
            return View();
        }
    }
}