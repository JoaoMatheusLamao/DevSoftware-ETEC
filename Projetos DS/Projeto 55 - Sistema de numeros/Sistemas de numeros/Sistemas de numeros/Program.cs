using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemas_de_numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int op_retorno = 0;
            float num;
            Console.WriteLine("Exibindo o triplo - WHILE");
            Console.WriteLine();
            while (op_retorno != -999)
            {
                op_retorno = 0;
                Console.Write("Entre com um numero qualquer: ");
                num = float.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("O triplo de " + num + " é igual a: " + 3*num);
                Console.WriteLine();
                Console.Write("Se desejar encerrar o processo, digite -999. Caso queira continuar, digite outro número: ");
                op_retorno = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine();
            }
        }
    }
}
