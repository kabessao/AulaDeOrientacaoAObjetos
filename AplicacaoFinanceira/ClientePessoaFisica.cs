using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AplicacaoFinanceira
{
    class ClientePessoaFisica : Cliente
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public ClientePessoaFisica()
        {

        }
        public ClientePessoaFisica(string nome, string cpf, string rg)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Rg = rg;
        }
    }
}