using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenando_números
{
    class Program
    {
        static void Main(string[] args)
        {
            double ent1, ent2, ent3, ent4, op1, op2, op3, op4, op5, op6, op7, op8, primeiro, segundo, terceiro, ultimo;
            Console.WriteLine("Ordenando números!!!");
            Console.WriteLine();
            Console.Write("Entre com um número qualquer: ");
            ent1 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com um número qualquer: ");
            ent2 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com um número qualquer: ");
            ent3 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com um número qualquer: ");
            ent4 = double.Parse(Console.ReadLine());
            Console.WriteLine();

            /*primeiro numero*/
            if (ent1 < ent2)
            {
                op1 = ent1;
            }
            else
            {
                op1 = ent2;
            }

            if (ent3 < ent4)
            {
                op2 = ent3;
            }
            else
            {
                op2 = ent4;
            }

            if (op1 < op2)
            {
                primeiro = op1;
            }
            else
            {
                primeiro = op2;
            }

            /*Segundo numero*/

            if (ent1 < ent2)
            {
                op3 = ent1;
            }
            else
            {
                op3 = ent2;
            }

            if (ent3 < ent4)
            {
                op4 = ent3;
            }
            else
            {
                op4 = ent4;
            }

            if (op3 > op4)
            {
                segundo = op3;
            }
            else
            {
                segundo = op4;
            }

            /*terceiro numero*/

            if (ent1 > ent2)
            {
                op5 = ent1;
            }
            else
            {
                op5 = ent2;
            }

            if (ent3 > ent4)
            {
                op6 = ent3;
            }
            else
            {
                op6 = ent4;
            }

            if (op5 < op6)
            {
                terceiro = op5;
            }
            else
            {
                terceiro = op6;
            }

            /*ultimo número*/
            if (ent1 > ent2)
            {
                op7 = ent1;
            }
            else
            {
                op7 = ent2;
            }

            if (ent3 > ent4)
            {
                op8 = ent3;
            }
            else
            {
                op8 = ent4;
            }

            if (op7 > op8)
            {
                ultimo = op7;
            }
            else
            {
                ultimo = op8;
            }
            Console.Write(primeiro);
            Console.Write(", ");
            Console.Write(segundo);
            Console.Write(", ");
            Console.Write(terceiro);
            Console.Write(", ");
            Console.Write(ultimo);
            Console.ReadLine();
        }
    }
}
