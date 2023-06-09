using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisão_dois_números_reais
{
    class Program
    {
        static void Main(string[] args)
        {
            float A, B, R;
            Console.WriteLine("Dividindo dois números reais");
            Console.WriteLine();
            Console.Write("Entre com o primeiro número real: ");
            A = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com o segundo valor real: ");
            B = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Dividindo...");
            R = A/B;
            Console.WriteLine();
            Console.WriteLine("O resultado é: " + R);
            Console.WriteLine();
            Console.WriteLine("Pra sair, digite qualquer tecla...");
            Console.ReadLine();
        }
    }
}
