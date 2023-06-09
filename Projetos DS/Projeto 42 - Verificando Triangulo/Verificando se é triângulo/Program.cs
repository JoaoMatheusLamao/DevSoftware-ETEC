using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificando_se_é_triângulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double med1, med2, med3;
            string tpTriangulo = "";
            /*Enunciado*/
            Console.WriteLine("Enunciado: ");
            Console.WriteLine();
            Console.WriteLine("Elaborar um programa em C# que leia três medidas e verifique se elas são compatíveis para \r\n" +
                              "formar um triângulo. Caso forme um triângulo, verificar ainda se o triângulo é equilátero, \r\n" +
                              "isoceles ou escaleno.\r\n" +
                              "Para ser um triângulo, a soma de dois lados qualquer deve ser sempre maior que um terceiro \r\n" +
                              "lado.\r\n" +
                              "Equilátero = todos os lados iguais;\r\n" +
                              "Isóceles = dois lados iguais;\r\n" +
                              "Escaleno = todos os lados diferentes.");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Entre com a primeira medida, em cm: ");
            med1 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com a segunda medida, em cm: ");
            med2 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com a terceira medida, em cm: ");
            med3 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            /*Verificando se é um triângulo*/
            if ((med1+med2) > med3 && (med2 + med3) > med1 && (med3 + med1) > med2)
            {
                /*Verificando tipo de triangulo*/
                if (med1 == med2 && med2 == med3)
                {
                    tpTriangulo = "As medidas inseridas equivalem a um triângulo: Equilátero";
                }
                else
                {
                    if (med1 == med2 || med2 == med3 || med3 == med1)
                    {
                        tpTriangulo = "As medidas inseridas equivalem a um triângulo: Isóceles";
                    }
                    else
                    {
                        if (med1 != med2 && med2 != med3)
                        {
                            tpTriangulo = "As medidas inseridas equivalem a um triângulo: Escaleno";
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("As medidas informadas não formam um triângulo");
            }
            Console.WriteLine(tpTriangulo);
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Para sair, aperte qualquer tecla...");
            Console.ReadLine();
        }
    }
}
