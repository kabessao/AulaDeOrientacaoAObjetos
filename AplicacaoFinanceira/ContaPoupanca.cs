using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoFinanceira
{
    class ContaPoupanca
    {
        public long Id { get; set; }
        public string Numero { get; set; }
        public double Saldo { get; set; }
        public short DiaDeAniversario { get; set; }
        public double TaxaDeCorrecao { get; set; }

    }
}
