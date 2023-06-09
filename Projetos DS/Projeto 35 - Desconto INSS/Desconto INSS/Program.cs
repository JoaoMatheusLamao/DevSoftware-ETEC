using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desconto_INSS
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, desconto, salarioDescontado;
            string nome;
            desconto = 0;
            salarioDescontado = 0;
            Console.WriteLine("Desconto INSS");
            Console.WriteLine();
            Console.Write("Entre com o nome do cliente: ");
            nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com o salário: R$ ");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine();
            /*isento*/
            if (salario <= 1000) 
            {
                desconto = 0;
                salarioDescontado = salario - desconto;
            }
            else
            {
                /*20%*/
                if (salario > 1000 && salario <= 1800)
                {
                    desconto = salario * 20 / 100;
                    salarioDescontado = salario - desconto;
                }
                else
                {
                    /*25%*/
                    if (salario > 1800 && salario <= 2500)
                    {
                        desconto = salario * 25 / 100;
                salarioDescontado = salario - desconto;
                    }
                    else
                    {
                        /*30%*/
                        if (salario > 2500)
                        {
                            desconto = salario * 30 / 100;
                            salarioDescontado = salario - desconto;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Cliente: " + nome);
            Console.WriteLine("Salário: R$ " + salario);
            Console.WriteLine("Valor do desconto: R$ " + Math.Round(desconto, 2));
            Console.WriteLine("Salário descontado: " + Math.Round(salarioDescontado,2));
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Para sair, aperte qualquer tecla...");
            Console.ReadLine();
        }
    }
}
