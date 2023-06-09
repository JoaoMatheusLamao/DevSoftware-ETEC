using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_de_dois_números
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, soma;
            Console.Write("Soma de dois números");
            Console.WriteLine();
            Console.Write("Digite um número inteiro: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite mais um número inteiro: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Somando...");
            soma = num1 + num2;
            Console.WriteLine("O resultado é: " + soma);
            Console.Write("Para sair, digite qualquer tecla!!!");
            Console.ReadLine();
        }
    }
}
