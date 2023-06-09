using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicial_do_cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, idade;
            string nome, sexo;
            i = 0;
            Console.WriteLine("Diferenciador de pessoas FOR");
            Console.WriteLine();
            for (i = 0; i < 14; i++)
            {
                Console.Write("Entre com o nome: ");
                nome = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Entre com o sexo da pessoa (M/F): ");
                sexo = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("-----------------------------------");
                if (idade > 21)
                    if (sexo == "F" || sexo == "f")
                    {
                        Console.WriteLine("Nome: " + nome);
                        Console.WriteLine("-----------------------------------");
                    }
            }
            Console.ReadLine();
            
        }
    }
}
