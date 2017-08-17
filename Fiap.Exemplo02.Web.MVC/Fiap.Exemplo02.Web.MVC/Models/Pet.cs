using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo02.Web.MVC.Models
{
    public class Pet
    {
        public int Codigo { get; set; }

        public String Nome { get; set; }

        public bool Castrado { get; set; }

        public String Descricao { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}