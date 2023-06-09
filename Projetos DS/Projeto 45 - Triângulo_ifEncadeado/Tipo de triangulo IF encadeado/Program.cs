using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipo_de_triangulo_IF_encadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            float lado1, lado2, lado3;
            string tpTriangulo = "";
            Console.WriteLine("Verificando tipo de triângulo - Estrutura Condicional Encadeada");
            Console.WriteLine();
            Console.Write("Informe a medida de um dos lados, em centímetros: ");
            lado1 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Informe a medida de um outro lado, em centímetros: ");
            lado2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Informe a medida de um outro lado, em centímetros: ");
            lado3 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            //Validando um triângulo//
            if ((lado1 + lado2) > lado3 && (lado2 + lado3) > lado1 && (lado1 + lado3) > lado2)
                //Verificando triângulo escaleno//
                if (lado1 != lado2 && lado2 != lado3 && lado3 != lado1)
                {
                    tpTriangulo = "formam um triângulo ESCALENO";
                }
                else
                {
                    ///verficando triângulo equilátero//
                    if (lado1 == lado2 && lado2 == lado3 && lado3 == lado1)
                    {
                        tpTriangulo = "formam um triângulo EQUILÁTERO";
                    }
                    else
                    {
                        //verificando triangulo ISÓCELES//
                        tpTriangulo = "formam um triângulo ISÓCELES";
                    }
                }
            else
            {
                tpTriangulo = "não formam um trângulo";
            }
            Console.WriteLine("As medidas inseridas " + tpTriangulo);
            Console.WriteLine();
            Console.Write("Para sair, aperte qualquer tecla...");
            Console.ReadLine();
                    
        }
    }
}
