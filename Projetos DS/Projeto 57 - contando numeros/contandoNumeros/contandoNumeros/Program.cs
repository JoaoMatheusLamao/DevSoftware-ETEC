using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contandoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            float num = 1;
            Console.WriteLine("Contando números");
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            while (num > 0)
            {
                Console.Write("Entre com um numero: ");
                num = float.Parse(Console.ReadLine());
                Console.WriteLine();
                if (num >= 100 && num <= 200)
                {
                    cont = cont + 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Foram digitados " + cont + " números entre 100 e 200");
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            Console.Write("Para sair, digite qualquer tecla.");
            Console.ReadLine();
        }
    }
}
