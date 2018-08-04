using System.Text;
using System.Threading.Tasks;


namespace AplicacaoFinanceira
{
    class Conta
    {
        public long Id { get; set; }
        public string Numero { get; set; }
        public double Saldo { get; set; }

        public Conta(long id, string numero, double saldo)
        {
            Id = id;
            Numero = numero;
            Saldo = saldo;
        }

        public Conta()
        {
            
        }
    }
}