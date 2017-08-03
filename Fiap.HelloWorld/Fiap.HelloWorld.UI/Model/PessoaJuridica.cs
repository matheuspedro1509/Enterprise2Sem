using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    class PessoaJuridica : Pessoa , ILoja
    {
        public string Cnpj { get; set; }

        //Construtor
        public PessoaJuridica(string nome) :base(nome)
        {

        }

        public override void Comprar()
        {
            Console.WriteLine("PJ comprando");
        }

        //Sobreescrever o método vender
        public override void Vender()
        {
            Console.WriteLine("PJ vendendo");
        }

        public void Devolver(string produto)
        {
            Console.WriteLine("Devolvendo produto: "+ produto);
        }
    }
}
