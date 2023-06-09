using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int op_retorno, num, resultado;
            op_retorno = 1;
            while (op_retorno == 1)
            {
                Console.WriteLine();
                Console.Write("Entre com um número inteiro: ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine();
                for (int i = 0; i < 11; i++)
                {
                    resultado = num * i;
                    Console.WriteLine(num + "X" + i + "=" + resultado);
                }
                Console.WriteLine();
                Console.Write("Se desejar refazer o processo, digite 1. Senão, digite 0 ----- ");
                op_retorno = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
