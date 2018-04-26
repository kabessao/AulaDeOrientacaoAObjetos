using System;

namespace AplicacaoFinanceira
{
    class AplicacaoFinanceira
    {
        static void Main(string[] args)
        {
            // ======definição de objetos====== //
            Banco banco1 = new Banco();
            Agencia agencia1 = new Agencia();
            Conta conta1 = new Conta();
            ContaCorrente contaCorrente1 = new ContaCorrente();
            ContaPoupanca contaPoupanca1 = new ContaPoupanca();

            // =====Mostrando os objetos===== //
            Console.WriteLine(banco1);
            Console.WriteLine(agencia1);
            Console.WriteLine(conta1);

            // =====Setando atributos em banco1===== //
            banco1.Id = 700;
            banco1.Numero = "2";
            banco1.Cnpj = "123456/00001-01";
            banco1.Nome = "Santander";

            // ===== exibindo os dados de banco1 ===== //
            Console.WriteLine("ID DO BANCO: " + banco1.Id);
            Console.WriteLine("O NÚMERO DO BANCO É: " + banco1.Numero);
            Console.WriteLine("O CNPJ DO BANCO É: " + banco1.Cnpj);
            Console.WriteLine("O NOME DO BANCO É: " + banco1.Nome);

            // ===== Setando atributos de agencia1 ===== //
            agencia1.Id = 12;
            agencia1.Numero = "22";
            agencia1.Nome = "Ag. Leme";

            // ===== Exibindo os dados de agencia1 ===== // 
            Console.WriteLine("ID DA AGENCIA: " + agencia1.Id);
            Console.WriteLine("O NÚMERO DA AGENCIA É: " + agencia1.Numero);
            Console.WriteLine("O NOME DA AGENCIA É: " + agencia1.Nome);

            // ===== Setando atributos de contaCorrente1 ===== //
            contaCorrente1.Id = 312;
            contaCorrente1.Limite = 9000;
            contaCorrente1.Numero = "89123";
            contaCorrente1.Saldo = "4000";

            // ===== Exibindo os dados de contaCorrente1 ===== //
            Console.WriteLine("id contaCorrente: "+ contaCorrente1.Id);
            Console.WriteLine("Limite contaCorrente: "+ contaCorrente1.Limite);
            Console.WriteLine("Numero contaCorrente: "+ contaCorrente1.Numero);
            Console.WriteLine("Saldo contaCorrente: "+ contaCorrente1.Saldo);

            // ===== Setando atributos de contaPoupanca1 ===== //
            contaPoupanca1.Id = 123; 
            contaPoupanca1.Numero = "4321"; 
            contaPoupanca1.Saldo = 10000; 
            contaPoupanca1.TaxaDeCorrecao = 2000;

            // ===== Exibindo os dados de contaPoupanca1 ===== //
            Console.WriteLine("Id contaPoupanca: "+ contaPoupanca1.Id); 
            Console.WriteLine("Numero contaPoupanca: "+ contaPoupanca1.Numero); 
            Console.WriteLine("Saldo contaPoupanca: "+ contaPoupanca1.Saldo); 
            Console.WriteLine("TaxaDeCorrecao contaPoupanca: "+ contaPoupanca1.TaxaDeCorrecao); 
        }
    }
}
