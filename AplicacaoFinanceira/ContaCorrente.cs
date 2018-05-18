using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoFinanceira
{
    class ContaCorrente : Conta
    {
        
        public ContaCorrente ()
        {

        }
        public ContaCorrente (long id, string numero, double saldo, double limite)
        {
            Id = id;
            Numero = numero;
            Saldo = saldo;
            Limite = limite;
        }

        private double _limite;
        public double Limite { get { return _limite; } set { _limite = value; } }

    }
}
