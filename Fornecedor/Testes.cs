using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fornecedor
{
    class Testes
    {
        static void Main(string[] args)
        {
            // ====== Exercício 2 ====== //
            Contato euMemo = new Contato( "Henrique Soares da Silva", 21, "123456789" );

            Console.WriteLine($"Olá {euMemo.Nome}. Sua idade em nosso sistema é {euMemo.Idade.ToString()} e seu" +
                $" número de telefone é {euMemo.Telefone}");
            Console.WriteLine("=========================");
            // ====== Fim Exercício 2 ====== //


            // ====== Exercício 3 ====== //
            Fornecedor forn1 = new Fornecedor("Henrique", 21, "123456789",  50,2000);
            Mensagem(forn1 as Fornecedor);
            // ====== Fim Exercício 3 ====== //
               
           
            // ====== Exercício 4 ====== //
            Object forn2 = new FornecedorNacional("João", 40, "982734987",1000,100);
            Mensagem(forn2 as Fornecedor);
            (forn2 as FornecedorNacional).ValorCredito = 800;
            Mensagem(forn2 as Fornecedor);
            
            Object forn3 = new FornecedorInternacional("José", 50, "298738752", 1000);
            Mensagem(forn3 as Fornecedor);
                (forn3 as FornecedorInternacional).ValorDivida = 20000;
            Mensagem((Fornecedor) forn3);
            // ====== Fim Exercício 4 ====== //
        }



        private static void Mensagem(Fornecedor fornecedor)
        {
            string mensagem = $"Olá, {fornecedor.Nome}. Seu saldo atual com nossa empresa é {fornecedor.Saldo()}. ";
            if (fornecedor.Saldo() > 0)
                mensagem += "Parabéns.";
            else
                mensagem += "Procure nossos serviços de crédito o quanto antes.";
            Console.WriteLine(mensagem);
            Console.WriteLine("============================");
        }
    }
}
