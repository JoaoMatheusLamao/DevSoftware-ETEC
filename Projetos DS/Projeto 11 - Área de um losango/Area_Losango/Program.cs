using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Losango
{
    class Program
    {
        static void Main(string[] args)
        {
            float d1, d2, area;
            Console.Write("Área de um Losango");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Para calcular a área do losango, é preciso saber as medidas das diagonais.");
            Console.Write("Portanto...");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Informe a medida da diagonal maior do losango, em cm: ");
            d1 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Informe a medida da diagonal menos do losango, em cm: ");
            d2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Calculando...");
            area = (d1 * d2) / 2;
            Console.WriteLine();
            Console.Write("A área do losango é: " + area);
            Console.Write("cm²");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Para sair, aperte qualquer tecla!!!");
            Console.ReadLine();
        }
    }
}
