using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exemplo04.MVC.Models
{
    public class Time
    {
        public int TimeId { get; set; }
        public string Nome { get; set; }
        public  DateTime DataFundacao { get; set; }

        //Relacionamento
        public Tecnico Tecnico { get; set; }
        public int TecnicoId { get; set; }

        public List<Jogador> Jogadores { get; set; }

        public List<Campeonato> Campeonatos { get; set; }
    }
}