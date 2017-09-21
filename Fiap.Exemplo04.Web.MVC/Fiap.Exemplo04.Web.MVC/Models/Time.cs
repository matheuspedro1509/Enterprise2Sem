using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.Web.MVC.Models
{
    public class Time
    {
        public int TimeId { get; set; }
        public string Nome { get; set; }
        public DateTime DataFundacao { get; set; }

        //  RELACIONAMENTO 1:1
        public Tecnico Tecnico { get; set; }
        public int TecnicoId { get; set; }

        // RELACIONAMENTO 1:N
        public List<Jogador> Jogadores { get; set; }

        public List<Campeonato> Campeonatos { get; set; }
    }
}