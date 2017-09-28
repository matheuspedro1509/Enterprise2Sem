using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.Web.MVC.Models
{
    public class Jogador
    {
        public int JogadorId { get; set; }

        [Required]
        public string Nome { get; set; }

        [Range(1,99)]
        public int Numero { get; set; }

        public Time Time { get; set; }
        public int TimeId { get; set; }
    }
}