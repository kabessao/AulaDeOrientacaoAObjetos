using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Fornecedor
{
    class Contato
    {

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }

        public Contato(string nome, int idade, string telefone)
        {
            Nome = nome;
            Idade = idade;
            Telefone = telefone;
        }
    }
}