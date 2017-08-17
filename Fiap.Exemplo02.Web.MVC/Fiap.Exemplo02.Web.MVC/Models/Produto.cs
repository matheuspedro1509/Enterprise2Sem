using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Fiap.Exemplo02.Web.MVC.Models
{
    public class Produto
    {
        public String Nome { get; set; }
        public decimal Preco { get; set; }
        public String Descricao { get; set; }
        public DateTime DataFabricacao { get; set; }
    }
}