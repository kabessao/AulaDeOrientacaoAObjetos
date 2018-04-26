using System;

namespace Exemplo1
{
    public class HelloCSharp
    {
        public static void Main(string[] args)
        {
            System.Out.Println("ola mundo");
        }
    }
    public static class System
    {
        public static class Out
        {
            public static void Println(string texto)
            {
                Console.WriteLine(texto);
            }
        }
    }
}
