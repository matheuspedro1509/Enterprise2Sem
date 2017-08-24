using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo02.Web.MVC.Models
{
    public class Pet
    {
        public int Codigo { get; set; }

        public String Nome { get; set; }

        public bool Castrado { get; set; }

        [Display(Name = "Descirção")]
        public String Descricao { get; set; }

        [Display(Name = "Data Nascimento")]
        public DateTime DataNascimento { get; set; }

        public String Especie{ get; set; }
    }
}