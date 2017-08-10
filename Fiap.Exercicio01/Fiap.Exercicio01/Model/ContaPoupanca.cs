using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio01.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {

        public decimal Taxa { get; set; }

        private readonly decimal _rendimento;

        public ContaPoupanca(decimal rend)
        {
            _rendimento = rend;
        }

        public decimal CalcularRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }

        public override void Depositar(decimal Valor)
        {
            Saldo += Valor;
        }

        public override void Retirar(decimal valor)
        {
            if(Saldo < valor)
            {
                throw new Exception("Saldo Insuficiente");
            }
            Saldo -= valor + Taxa;
        }
    }
}
