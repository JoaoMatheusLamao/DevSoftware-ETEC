using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertendo_o_sinal_dos_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Declaração de variáveis*/
            double num, numInvert;
            string mensagem;

            /*Enunciado*/
            Console.WriteLine("Enunciado:\r\n \r\n" +
                "Elaborar um programa que inverta o sinal de um número qualquer. Se o número for positivo, transformar\r\n" +
                "em negativo e vice-versa. Exibir um relátorio sobre o número entrado e sobre o que foi feito");

            /*Programa*/
            Console.WriteLine();
            Console.WriteLine("Programa:");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Entre com um número qualquer: ");
            num = double.Parse(Console.ReadLine());
            numInvert = num * -1;
            Console.WriteLine();
            if (num > 0)
            {
                mensagem = "O número inserido é positivo. \r\n" +
                            "O número inserido foi convertido para um número negativo.";
            }
            else
            {
                if (num < 0)
                {
                    mensagem = "O número inserido é negativo. \r\n" +
                            "O número inserido foi convertido para um número positivo.";
                }
                else
                {
                    mensagem = "O número inserido é igual a 0, portanto é nulo";
                }
            }
            Console.WriteLine(mensagem);
            Console.WriteLine();
            Console.WriteLine("A conversão do número resulta em: " + numInvert);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Para sair, aperte qualquer tecla...");
            Console.ReadLine();
        }
    }
}
