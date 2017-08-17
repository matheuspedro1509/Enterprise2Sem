using Fiap.Exemplo02.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo02.Web.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private static List<Produto> produtos = new List<Produto>();
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        public ActionResult Cadastrar(Produto p)
        {
            produtos.Add(p);
            TempData["mensagem"] = "Cadastrado";
            return View();
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View();
        }
    }
}