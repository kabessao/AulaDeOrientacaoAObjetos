using System;

namespace AplicacaoFinanceira
{
    class AplicacaoFinanceira
    {
        static void Main(string[] args)
        {
            // ======definição de objetos====== //
            Banco banco1 = new Banco(700, "2","123456/0000001-01","Santander");
            Agencia agencia1 = new Agencia(12,"22","Ag. leme");
            ContaCorrente contaCorrente1 = new ContaCorrente(123,"019283",20000,4000);
            ContaPoupanca contaPoupanca1 = new ContaPoupanca(123,"019283",20000,2000, 0918723);
            ClientePessoaFisica clientePessoaFisica1 = new ClientePessoaFisica("Jão", "0912830", "13218293");
            ClientePessoaJuridica clientePessoaJuridica1 = new ClientePessoaJuridica("Jão", "0830");

            // =====Mostrando os objetos===== //
            Console.WriteLine(banco1);
            Console.WriteLine(agencia1);
            ClientePessoaFisica clientePessoaFisica = new ClientePessoaFisica();
            clientePessoaFisica.Cpf = "092813092";
            Console.WriteLine(clientePessoaFisica.Cpf);
            // ===== exibindo os dados de banco1 ===== //
            Console.WriteLine("ID do banco : " + banco1.Id);
            Console.WriteLine("O Número do banco : " + banco1.Numero);
            Console.WriteLine("O Cnpj do banco : " + banco1.Cnpj);
            Console.WriteLine("O Nome do banco : " + banco1.Nome);

            // ===== Exibindo os dados de agencia1 ===== // 
            Console.WriteLine("ID da agencia: " + agencia1.Id);
            Console.WriteLine("O Número da agencia : " + agencia1.Numero);
            Console.WriteLine("O Nome da agencia : " + agencia1.Nome);

            // ===== Exibindo os dados de contaCorrente1 ===== //
            Console.WriteLine("id contaCorrente : "+ contaCorrente1.Id);
            Console.WriteLine("Limite contaCorrente : "+ contaCorrente1.Limite);
            Console.WriteLine("Numero contaCorrente : "+ contaCorrente1.Numero);
            Console.WriteLine("Saldo contaCorrente : "+ contaCorrente1.Saldo);

            Console.WriteLine(contaCorrente1.Numero);
            // ===== Exibindo os dados de contaPoupanca1 ===== //
            Console.WriteLine("Id contaPoupanca : "+ contaPoupanca1.Id); 
            Console.WriteLine("Numero contaPoupanca : "+ contaPoupanca1.Numero); 
            Console.WriteLine("Saldo contaPoupanca : "+ contaPoupanca1.Saldo); 
            Console.WriteLine("TaxaDeCorrecao contaPoupanca : "+ contaPoupanca1.TaxaDeCorrecao);

            // ====== Exibindo os dados de clientePessoaJuridica1 ====== //
            Console.WriteLine("Nome clientePessoaJuridica1 :"+ clientePessoaJuridica1.Nome);
            Console.WriteLine("Cnpj clientePessoaJuridica1 :"+ clientePessoaJuridica1.Cnpj);

            // ====== Exibindo os dados de clientePessoaFisica ====== //
            Console.WriteLine("Nome clientePessoaFisica :"+ clientePessoaFisica1.Nome );
            Console.WriteLine("Cpf clientePessoaFisica :"+ clientePessoaFisica1.Cpf );
            
        }
    }
}
