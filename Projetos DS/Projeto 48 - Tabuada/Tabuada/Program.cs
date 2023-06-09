using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, fator2;
            float num, resultado;
            fator2 = 0;
            Console.WriteLine("Tabuada de um número qualquer");
            Console.WriteLine();
            Console.Write("Digite o número que você deseja saber a tabuada: ");
            num = float.Parse(Console.ReadLine());
            Console.WriteLine();
            for (i = 0; i <= 10; i++)
            {
                resultado = num * fator2;
                Console.Write(num + " X " + fator2 + " = " + resultado);
                Console.WriteLine();
                fator2++;
            }
            Console.ReadLine();
        }
    }
}
