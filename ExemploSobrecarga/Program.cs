using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSobrecarga
{
    static class Program
    {
        static void Main(string[] args)
        {
            Object prof1 = new Professor("00012.1", "José", 1000.0f, (byte)4);
            Object prof2 = new ProfessorPosGraduacao("00232-6", "Patrícia", 1000.0f, (byte)4, (byte)5, (short)2);
            Console.WriteLine("O salario líquido do José é de RS" + (prof1 as Professor).CalcularSalarioLiquido());
            Console.WriteLine("O salario líquido do Patrícia é de RS" + (prof2 as ProfessorPosGraduacao) .CalcularSalarioLiquido());
            
            

        }
    }
}
