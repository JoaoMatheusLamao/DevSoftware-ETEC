using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada_do_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cont, result;
            cont = 0;
            Console.WriteLine("Tabuada usando o DO_WHILE");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.Write("Digite um número inteiro: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            do
            {
                result = num * cont;
                Console.WriteLine(num + " x " + cont + " = " + result);
                cont++;
            } while (cont <= 10);
            Console.ReadLine();
        }
    }
}
