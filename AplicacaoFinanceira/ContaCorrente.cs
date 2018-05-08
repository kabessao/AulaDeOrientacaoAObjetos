using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoFinanceira
{
    class ContaCorrente
    {
        
        public ContaCorrente ()
        {

        }
        public ContaCorrente (long id, string numero, string saldo, double limite)
        {
            _id = id;
            _numero = numero;
            _saldo = saldo;
            _limite = limite;
        }
        private long _id;
        public long Id { get { return _id; } set { _id = value; } }

        private string _numero;
        public string Numero { get { return _numero; } set { _numero = value; } }

        private string _saldo;
        public string Saldo { get { return _saldo; } set { _saldo = value; } }

        private double _limite;
        public double Limite { get { return _limite; } set { _limite = value; } }

    }
}
