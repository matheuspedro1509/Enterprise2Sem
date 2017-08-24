using Fiap.Exemplo02.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exemplo02.Web.MVC.Controllers
{
    public class PetController : Controller
    {

        //Simular o banco de dados
        private static List<Pet> _banco = new List<Pet>();
        
        [HttpGet]
        public ActionResult Cadastro()
        {
            List<string> especies = new List<string>();
            especies.Add("Cachorro");
            especies.Add("Gato");
            especies.Add("Pássaro");
            especies.Add("Peixe");
            ViewBag.opcoes = new SelectList(especies);
           return View();
        }

        [HttpPost]
        public ActionResult Cadastro(Pet pet)
        {
            //grava no banco
            _banco.Add(pet);
            //Mensagem de sucesso
            TempData["msg"] = "Cadastrado";
            ViewBag.mensagem = "Cadastrou";
            return RedirectToAction("Cadastro");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            //Passar os pets cadastrados para a view 
            return View(_banco);
        }
    }
}