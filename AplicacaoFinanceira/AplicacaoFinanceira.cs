using System;

namespace AplicacaoFinanceira
{
    class AplicacaoFinanceira
    {
        static void Main(string[] args)
        {
            Banco banco1 = new Banco();
            Agencia agencia1 = new Agencia();
            Conta conta1 = new Conta();
            Console.WriteLine(banco1);
            Console.WriteLine(agencia1);
            Console.WriteLine(conta1);
        }
    }
}
