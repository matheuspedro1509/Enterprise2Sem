using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio01.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            var cc = new ContaCorrente()
            {
                Agencia = 123,
                Numero = 456,
                DataAbertura = DateTime.Now,
                Saldo = 100,
                Tipo = Model.TipoConta.Comum
            };

            var cp = new ContaPoupanca(0.06m)
            {
                Agencia = 123,
                DataAbertura = DateTime.Now,
                Numero = 456,
                Saldo = 500,
                Taxa = 1
            };

            //Chamar os 
            cc.Depositar(100);
            cc.Retirar(50);
            Console.WriteLine("Saldo conta corrente "+ cc.Saldo);
            Console.Write("Saldo conta poupanca "+ cp.CalcularRetornoInvestimento());
            Console.ReadLine();   
        }
    }
}
