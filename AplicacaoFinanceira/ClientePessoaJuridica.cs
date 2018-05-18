using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AplicacaoFinanceira
{
    class ClientePessoaJuridica : Cliente
    {
        public ClientePessoaJuridica()
        {

        }
        public ClientePessoaJuridica(string nome, string cnpj)
        {
            this.Nome = nome;
            this.Cnpj = cnpj;
        }
        public string Cnpj { get; set; }
    }
}