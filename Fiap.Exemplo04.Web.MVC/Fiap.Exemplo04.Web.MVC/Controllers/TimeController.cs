using Fiap.Exemplo04.Web.MVC.Models;
using Fiap.Exemplo04.Web.MVC.Persistencia;
using Fiap.Exemplo04.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo04.Web.MVC.Controllers
{
    public class TimeController : Controller
    {

        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_unit.TimeRepository.Listar());
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Time time)
        {
            _unit.TimeRepository.Cadastrar(time);
            _unit.Salvar();
            TempData["msg"] = "Time Cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}