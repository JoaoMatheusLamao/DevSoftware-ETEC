using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume_de_um_galão
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, H, VOL;
            Console.Write("Volume de um galão");
            Console.WriteLine();
            Console.Write("Entre com o valor do raio do galão, em cm: ");
            R = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com a altura do galão, em cm: ");
            H = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Calculando...");
            Console.WriteLine();
            Console.WriteLine();
            VOL = 3.14159*(R*R)*H;
            Console.WriteLine("O resultado é: " + VOL, "cm³");
            Console.ReadLine();
        }
    }
}
