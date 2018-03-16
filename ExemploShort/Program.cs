using System;

namespace ExemploShort
{
    class Program
    {
        static void Main(string[] args)
        {
            short teste = 3000 + 3000;
            // não foi possivel usar 'casting' no short, aparentemente o .net não aceita.
            Console.WriteLine(teste);
        }
    }
}
