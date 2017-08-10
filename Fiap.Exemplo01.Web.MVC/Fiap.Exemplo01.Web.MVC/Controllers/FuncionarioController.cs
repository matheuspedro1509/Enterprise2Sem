using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fiap.Exemplo01.Web.MVC.Models;

namespace Fiap.Exemplo01.Web.MVC.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        [HttpGet]
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Gravar(Funcionario func)
        {
            ViewBag.nome = func.Nome;
            ViewBag.data = func.Data;
            ViewBag.salario = func.Salario;
            return View(func);
        }
    }
}