using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificacao_de_faixa_pertencente
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("Verificando se um número está entre 20 e 90");
            Console.WriteLine();
            Console.Write("Entre com um número qualquer: ");
            num = double.Parse(Console.ReadLine());
            Console.WriteLine();
            if (num >= 20 && num <=90)
            {
            Console.WriteLine("O número inserido está entre 20 e 90");
            }
            else
            {
                Console.WriteLine("O número inserido não está entre 20 e 90");
            }
            Console.WriteLine();
            Console.Write("Para sair, aperte qualquer tecla: ");
            Console.ReadLine();
        }
    }
}
