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
    public class JogadorController : Controller
    {
         private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            //Busca todos os times
            var lista = _unit.TimeRepository.Listar();
            ViewBag.times = new SelectList(lista , "TimeId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Jogador jogador)
        {
            _unit.JogadorRepository.Cadastrar(jogador);
            _unit.Salvar();
            TempData["msg"] = "Jogador cadastrado com sucesso";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_unit.JogadorRepository.Listar());
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}