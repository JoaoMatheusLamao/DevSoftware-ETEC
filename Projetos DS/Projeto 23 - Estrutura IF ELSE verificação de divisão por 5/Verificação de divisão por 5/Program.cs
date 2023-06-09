using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificação_de_divisão_por_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.Write("Verificando divisão exata");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Digite um número qualquer: ");
            num = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("--------------------------------------------------");
            Console.WriteLine();
            if (num % 5 == 0)
            {
                Console.WriteLine();
                Console.Write("O número é divisível por 5!!!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.Write("O número não é divisível por 5!!!");
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
