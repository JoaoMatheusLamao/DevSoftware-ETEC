using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverter_variáveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            Console.Write("Invertendo variáveis");
            Console.WriteLine();
            Console.Write("Entre com um valor ''x'' inteiro: ");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com um valor ''y'' inteiro: ");
            Y = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Invertendo...");
            X += Y;
            Y = X - Y;
            X -= Y;
            Console.Write("As variáveis, invertidas, são: ");
            Console.Write("X = " + X);
            Console.Write("; Y = " + Y);
            Console.WriteLine();
            Console.Write("àra sair aperte qualquer tecla!");
            Console.ReadLine();
        }

    }
}
