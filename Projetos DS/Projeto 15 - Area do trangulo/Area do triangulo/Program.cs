using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_do_triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, area, b;
            Console.Write("Área do trângulo!!!");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Entre com a medida da base do trângulo, em cm: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Entre com a medida da altura do trângulo, em cm: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Calculando...");
            area = (b*altura)/2;
            Console.WriteLine();
            Console.Write("A area do triângulo é de: " + area);
            Console.Write(" cm²");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Para sair, digite qualquer tecla");
            Console.ReadLine();
        }
    }
}
