using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_IF__SOMA_
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, resultadoSoma;
            Console.Write("Estrutura IF - Somando dois números!");
            Console.WriteLine();
            Console.Write("Entre com um número qualquer: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com um outro nímero qualquer: ");
            num2 = float.Parse(Console.ReadLine());
            resultadoSoma = num1 + num2;
            Console.WriteLine();
            Console.WriteLine();
            if (resultadoSoma > 15)
            {
                Console.WriteLine("O resultado da soma é: " + resultadoSoma);
            }
            Console.ReadLine();
        }
    }
}

