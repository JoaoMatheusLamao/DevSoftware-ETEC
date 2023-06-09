using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversão_de_Temperaturas_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double gc, gf;
            Console.Write("Conversor de temperatura!!!");
            Console.WriteLine();
            Console.Write("Entre com a temperatura em graus Fahrenheit: ");
            gf = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Convertendo para Celsius...");
            gc = (gf - 32) / 1.8;
            Console.WriteLine();
            Console.Write("A temperatura, em Celsius, é: " + gc);
            Console.Write("°C");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Para sair, digite qualquer tecla");
            Console.ReadLine();
        }
    }
}
