using System;

namespace KeyboardReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:\n");
            string nome = Console.ReadLine();
            if (string.IsNullOrEmpty(nome))
                Console.WriteLine("Se é burro cara");
            else
                Console.WriteLine("O nome digitado foi: " + nome);
        }
    }
}
