using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicação_de_dois_valores_reais
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, B, R;
            Console.Write("Multiplicando dois números reais!");
            Console.WriteLine();
            Console.Write("Entre com o primeiro número real: ");
            A = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com o segundo valor real: ");
            B = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Multiplicando...");
            R = A * B;
            Console.WriteLine();
            Console.Write("O resultado é: " + R);
            Console.WriteLine();
            Console.WriteLine("Pra sair, digite qualquer tecla...");
            Console.ReadLine();
        }
    }
}
