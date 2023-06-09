using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificação_IF_Par_or_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.Write("Verificando se um número é par ou ímpar");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Digite um número qualquer: ");
            num = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("--------------------------------------------------");
            Console.WriteLine();
            if (num % 2 == 0)
            {
                Console.WriteLine();
                Console.Write("O número é par!!!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.Write("O número é ímpar!!!");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.Write("--------------------------------------------------");
            Console.WriteLine();
            Console.Write("Para sair digite qualquer tecla...");
            Console.ReadLine();
        }
    }
}
