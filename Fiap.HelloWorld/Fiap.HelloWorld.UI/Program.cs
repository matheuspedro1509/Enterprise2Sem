using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.HelloWorld.UI.Model;

namespace Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar a PessoaJuridica
            PessoaJuridica pessoaJur = new PessoaJuridica("Microsoft");

            //Colocar valores nos atributos
            pessoaJur.Cnpj = "123.456/78";

            //Exibir Nome
            Console.WriteLine(pessoaJur.Nome);
            

            PessoaFisica pf = new PessoaFisica("Mat")
            {
                Cpf = "1234567891011"
            };

            Console.WriteLine("Lista de pessoas :");
            //Lista de pessoa Fisica
            List<PessoaFisica> pfisicas = new List<PessoaFisica>();
            pfisicas.Add(new PessoaFisica("Maria"));
            pfisicas.Add(new PessoaFisica("João"));

            //Imprimir os valores
            foreach ( var item in pfisicas)
            {
                Console.WriteLine(item.Nome);
            }

            
            Console.ReadLine(); //Parar a explicação
        }
    }
}
 