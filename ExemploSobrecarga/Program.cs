using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            ProfessorGraduacao prof1 = new ProfessorGraduacao("00012.1", "José", 1000.0f, (byte)4);
            ProfessorPosGraduacao prof2 = new ProfessorPosGraduacao("00232-6", "Patrícia", 1000.0f, (byte)4, (byte)5, (short)2);
            Console.WriteLine("O salario líquido do José é de RS" + prof1.CalcularSalario());
            Console.WriteLine("O salario líquido do Patrícia é de RS" + prof2.CalcularSalario());

        }
    }
}
