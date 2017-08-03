using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaCorrente : Conta
    {
        public TipoConta TipoConta { get; set; }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            Saldo -= valor;

            if (TipoConta == TipoConta.Comum && Saldo < 0)
            {
                throw new System.ArgumentException("Seu saldo ficara negativo") ;
            }
            {

            }
        }
    }
}
