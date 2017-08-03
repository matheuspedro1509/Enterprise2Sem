﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }

        public Sexo Sexo { get; set; }

        public PessoaFisica(string nome) :base (nome)
        {

        }

        public override void Comprar()
        {
            Console.WriteLine("PF comprando");
        }
    }
}
