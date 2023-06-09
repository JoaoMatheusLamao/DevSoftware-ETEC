using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtração_de_dois_números
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1, NUM2, R;
            Console.Write("Subtração!!!");
            Console.WriteLine();
            Console.Write("Entre com o primeiro número: ");
            NUM1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com o segundo numero: ");
            NUM2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Subtraíndo...");
            R = NUM1 - NUM2;
            Console.WriteLine();
            Console.Write("O resultado é: " + R);
            Console.WriteLine();
            Console.Write("Tecle qualquer tecla para sair");
            Console.ReadLine();
        }
    }
}
