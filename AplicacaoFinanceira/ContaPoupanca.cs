using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoFinanceira
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca()
        {

        }
        public ContaPoupanca(long id, string numero, double saldo, short diaDeAniversario, double taxaDeCorrecao)
        {
            Id = id;
            Numero = numero;
            Saldo = saldo;
            DiaDeAniversario = diaDeAniversario;
            TaxaDeCorrecao = taxaDeCorrecao;
        }
        public short DiaDeAniversario { get; set; }
        public double TaxaDeCorrecao { get; set; }

    }
}
