using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, fatorial;
            Console.WriteLine("Calculando o fatorial de um número.");
            Console.WriteLine();
            Console.Write("Entre com um número inteiro: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine();
            fatorial = 1;
            do
            {
                fatorial = fatorial * numero;
                numero = numero - 1;
            } while (numero != 1);
            Console.WriteLine("Resultado: " + fatorial);
            Console.ReadLine();
        }
    }
}