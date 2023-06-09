using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_IF___Número_positivo_ou_negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1;
            Console.Write("Estrutura IF - Verificando se um número é positivo!");
            Console.WriteLine();
            Console.Write("Entre com um número qualquer: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            if (num1 > 0)
            {
                Console.WriteLine("O número é positico e, elevando ao quadrado, obtemos o valor: " + Math.Pow(num1,2));
            }
            Console.ReadLine();
        }
    }
}
