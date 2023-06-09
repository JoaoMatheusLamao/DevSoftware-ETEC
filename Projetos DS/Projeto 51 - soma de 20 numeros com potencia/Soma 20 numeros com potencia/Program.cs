using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_20_numeros_com_potencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double num, soma;
            soma = 0;
            Console.WriteLine("Efetuando calculo com estrutura de repetição, de decisão e potenciação");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            for (i = 1; i <= 20; i++)
            {
                Console.Write("Entre com um número qualquer: ");
                num = double.Parse(Console.ReadLine());
                Console.WriteLine();
                if ((Math.Pow(num,2)) < 225)
                {
                    soma = soma + num;
                }
            }
            Console.WriteLine("A soma dos numeros cujo o quadrado é menor que 225 é " + soma);
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Para sair, precione ENTER...");
            Console.ReadLine();
        }
    }
}
