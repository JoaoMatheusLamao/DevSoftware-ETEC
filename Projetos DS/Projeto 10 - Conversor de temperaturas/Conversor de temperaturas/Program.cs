using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_temperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            double gc, gf;
            Console.Write("Conversor de temperatura!!!");
            Console.WriteLine();
            Console.Write("Entre com a temperatura em graus Celsius: ");
            gc = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Convertendo para Fahrenheit...");
            gf = 1.8 * gc + 32;
            Console.WriteLine();
            Console.Write("A temperatura, em Fahrenheit, é: " + gf);
            Console.Write("°F");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Para sair, digite qualquer tecla");
            Console.ReadLine();
        }
    }
}
