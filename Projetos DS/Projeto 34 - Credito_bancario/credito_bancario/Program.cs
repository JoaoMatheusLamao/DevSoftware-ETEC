using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace credito_bancario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double saldoMedio, credito;
            credito = 0;
            Console.WriteLine("Crédito bancário!");
            Console.WriteLine();
            Console.Write("Entre com o nome do cliente: ");
            nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com o saldo médio no ultimo ano: R$ ");
            saldoMedio = double.Parse(Console.ReadLine());
            /*Nenhum crédito*/
            if (saldoMedio <= 500)
            {
                credito = 0;
            }
            else
            {
                /*30%*/
                if (saldoMedio>=501 && saldoMedio<=1000)
                {
                    credito = saldoMedio*30/100;
                }
                else
                {
                    /*40%*/
                    if (saldoMedio>=1001 && saldoMedio<=3000)
                    {
                        credito = saldoMedio*40/100;
                    }
                    else
                    {
                        /*50%*/
                        if (saldoMedio >= 3001)
                        {
                            credito = saldoMedio * 50 / 100;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Cliente: " + nome);
            Console.WriteLine("Saldo médio: R$ " + Math.Round(saldoMedio,2));
            Console.WriteLine("Valor do crédito: R$ "+ Math.Round(credito, 2));
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Para sair, aperte qualquer tecla: ");
            Console.ReadLine();

        }
    }
}
