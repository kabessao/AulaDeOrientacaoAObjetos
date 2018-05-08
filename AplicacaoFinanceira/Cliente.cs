using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AplicacaoFinanceira
{
    class Cliente
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _cpf;

        public string Cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public Cliente()
        {

        }
        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

    }
}