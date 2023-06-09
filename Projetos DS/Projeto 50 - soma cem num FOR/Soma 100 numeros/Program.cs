using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_100_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, soma;
            soma = 0;
            Console.WriteLine("Somando os cem primeiros números - Estrutura FOR");
            Console.WriteLine();
            Console.Write("Precione qualquer tecla para começas a soma... ");
            Console.ReadLine();
            for (i = 1; i <= 100; i++)
            {
                soma = soma + i;
            }
            Console.WriteLine();
            Console.WriteLine("Resultado = " + soma);
            Console.WriteLine();
            Console.Write("Para sair, aperte qualquer tecla...");
            Console.ReadLine();
        }
    }
}
