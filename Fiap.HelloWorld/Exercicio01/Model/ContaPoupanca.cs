using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {

        public decimal Taxa { get; set; }

        //public readonly decimal _rendimento { get; set; }
        // falta a partir do ex 5
        public double CalcularRetornoInvestimento()
        {
            throw new NotImplementedException();
        }

        public override void Depositar(decimal valor)
        {
            throw new NotImplementedException();
        }

        public override void Retirar(decimal valor)
        {
            throw new NotImplementedException();
        }
    }
}
