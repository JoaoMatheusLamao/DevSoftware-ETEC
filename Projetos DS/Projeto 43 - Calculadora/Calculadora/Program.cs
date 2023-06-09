using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultado;
            string operacao, tpOp;

            resultado = 0;
            tpOp = "";
            /*Enunciado*/
            Console.WriteLine("Enunciado:");
            Console.WriteLine();
            Console.WriteLine("Elaborar um programa C# que execute calculos com dois números. \r\n" +
                "O usuário deve entrar com dois números e também deve escolher a operação a ser realizada.");
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();

            /*Programa*/
            Console.Write("Entre com o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Operações: \r\n" +
                "1 --- Adição\r\n" +
                "2 --- Subtração \r\n" +
                "3 --- Multiplicação\r\n" +
                "4 --- Divisão\r\n");
            Console.WriteLine();
            Console.Write("Escolha a operação: ");
            operacao = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com o segundo número: ");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine();
            /*Calculo*/
            if (operacao == "1" || operacao == "Adição")
            {
                resultado = num1 + num2;
                tpOp = " + ";
            }
            else
            {
                if (operacao == "2" || operacao == "Subtração")
                {
                    resultado = num1 - num2;
                    tpOp = " - ";
                }
                else
                {
                    if (operacao == "3" || operacao == "Multiplicação")
                    {
                        resultado = num1 * num2;
                        tpOp = " * ";
                    }
                    else
                    {
                        if (operacao == "4" || operacao == "Divisão")
                        {
                            resultado = num1 / num2;
                            tpOp = " / ";
                        }
                    }
                }
            }
            /*Relatório*/
            Console.WriteLine("Calculo: " + num1 + tpOp + num2 + " = " + resultado);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Para sair, aperte qualquer tecla...");
            Console.ReadLine();
        }
    }
}
