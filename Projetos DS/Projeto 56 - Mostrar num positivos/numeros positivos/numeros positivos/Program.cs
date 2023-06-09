using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_positivos
{
    class Program
    {
        static void Main(string[] args)
        {
            float num =0;
            Console.WriteLine("Este programa se encerra quando um numero negativo for digitado");
            Console.WriteLine();
            while (num >= 0)
            {
                Console.Write("Entre com um número qualquer: ");
                num = float.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("O número digitado foi: " + num);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
