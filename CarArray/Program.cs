using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarArray
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] carros = new string[] { "Porshe", "Ferrari", "Maserati" };
            for (int i = 0; i < carros.Length; i++)
            {
                Console.WriteLine(carros[i]);
            }
            
        }

    }
}
