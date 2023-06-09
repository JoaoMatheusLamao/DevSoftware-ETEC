using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculando_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double altura, peso, imc;
            Console.WriteLine("Calculando IMC");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Entre com o nome do paciente: ");
            nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com a altura do paciente, em metros: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com o peso do paciente, em quilogramas: ");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Calculando...");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine();
            imc = peso / Math.Pow(altura, 2);
            /*Abaixo do peso*/
            if (imc < 20)
            {
                Console.WriteLine("Paciente: " + nome);
                Console.WriteLine("Taxa IMC: " + Math.Round(imc,3));
                Console.WriteLine("Faixa de risco: Abaixo do peso");
            }
            else
            {
            /*Normal*/
                if (imc > 20 && imc <= 25)
                {

                    Console.WriteLine("Paciente: " + nome);
                    Console.WriteLine("Taxa IMC: " + Math.Round(imc, 3));
                    Console.WriteLine("Faixa de risco: Normal");
                }
                else
                {
                    /*Excesso de peso*/
                    if (imc > 25 && imc <= 30)
                    {
                        Console.WriteLine("Paciente: " + nome);
                        Console.WriteLine("Taxa IMC: " + Math.Round(imc, 3));
                        Console.WriteLine("Faixa de risco: Excesso de peso");
                    }
                    else
                    {
                        /*Obesidade*/
                        if (imc > 30 && imc <=35)
                        {
                            Console.WriteLine("Paciente: " + nome);
                            Console.WriteLine("Taxa IMC: " + Math.Round(imc, 3));
                            Console.WriteLine("Faixa de risco: Obesidade");
                        }
                        else
                        {
                            /*Obesidade mórbida*/
                            if (imc > 35)
                            {
                                Console.WriteLine("Paciente: " + nome);
                                Console.WriteLine("Taxa IMC: " + Math.Round(imc, 3));
                                Console.WriteLine("Faixa de risco: Obesidade Mórbida");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");
            Console.Write("Para sair, aperte qualquer tecla: ");
            Console.ReadLine();
        }
    }
}
