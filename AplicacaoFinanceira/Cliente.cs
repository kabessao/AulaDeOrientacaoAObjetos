using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AplicacaoFinanceira
{
    public class Cliente
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public Cliente()
        {

        }
        public Cliente(string nome)
        {
            Nome = nome;
        }

    }
}