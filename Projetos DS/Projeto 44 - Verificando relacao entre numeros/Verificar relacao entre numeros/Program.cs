using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificar_relacao_entre_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, diferenca;
            string sit1, sit2;

            /*Enunciado*/
            Console.WriteLine("Escrever  um  programa  que  leia  dois  números  inteiros  e  mostre  todos  os relacionamentos \r\n" +
                              "de  ordem  existentes entre eles.Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor.\r\n" +
                              "");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            /*Programa*/
            Console.Write("Entre com um número qualquer: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com um outro número qualquer: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            if (num1 == num2)
            {
                sit1 = "O primeiro número é igual ao segundo.";
                sit2 = "Os números são iguais, portanto não a diferenças entre eles. ";
                diferenca = 0;
            }
            else
            {
                sit1 = "O primeiro número não é igual ao segundo.";
                if (num1 > num2)
                {
                    sit2 = "O primeiro número é maior que o segundo.";
                    diferenca = num1 - num2;
                }
                else
                {
                    sit2 = "O primeiro número é menor que o segundo.";
                    diferenca = num2 - num1;
                }
            }
            Console.WriteLine("Relatório: ");
            Console.WriteLine();
            Console.WriteLine("Relação: " + sit1);
            Console.WriteLine("Outras relações: " + sit2);
            Console.WriteLine("A diferença entre os números é de: " + diferenca);
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Para sair, aperte qualquer tecla...");
            Console.ReadLine();
        }
    }
}
