using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiz_Quadrada
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, resultado;
            Console.Write("Efetuando cálculo com raiz");
            Console.WriteLine();
            Console.Write("Digite um número qualquer: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Efetuando cálculo");
            resultado = Math.Sqrt(num1);
            Console.WriteLine();
            Console.WriteLine("O resultado é " + resultado);
            Console.ReadLine();
        }
    }
}
