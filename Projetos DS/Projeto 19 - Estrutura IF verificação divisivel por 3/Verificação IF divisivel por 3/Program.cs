using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificação_IF_divisivel_por_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.Write("Estrutura IF - Verificando se um número é divisivel por 3");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Entre com um número inteiro qualquer: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            if (num1 % 3 == 0)
            {
                Console.WriteLine("O número inserido é divisivel por três!!!");
            }
            Console.ReadLine();
        }
    }
}
