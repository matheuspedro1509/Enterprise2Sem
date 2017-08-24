using Fiap.Exemplo03.Web.MVC.Models;
using Fiap.Exemplo03.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo03.Web.MVC.Controllers
{
    public class ApostadorController : Controller
    {

        private static List<LoteriaContext> banco = new List<LoteriaContext>();

        // GET: Apostador
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(Apostador apost)
        {
            //grava no banco
            banco.Add(apost);
            //Mensagem de sucesso
            TempData["msg"] = "Cadastrado";
            ViewBag.mensagem = "Cadastrou";
            return RedirectToAction("Cadastro");
        }
    }
}