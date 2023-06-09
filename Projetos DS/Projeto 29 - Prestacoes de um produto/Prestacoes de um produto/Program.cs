using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestacoes_de_um_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeProduto;
            double valorProduto, valorPrestacoes;
            int nPrestacoes;
            Console.WriteLine("Calculando o valor das prestações de um produto");
            Console.WriteLine();
            Console.Write("Entre com o nome do produto: ");
            nomeProduto = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com o valor do produto: R$ ");
            valorProduto = double.Parse(Console.ReadLine());
            Console.WriteLine();
            if (valorProduto >= 300)
            {
                nPrestacoes = 3;
            }
            else
            {
                nPrestacoes = 2;
            }
            Console.WriteLine();
            Console.WriteLine();
            valorPrestacoes = valorProduto / nPrestacoes;
            Console.WriteLine("Nome do produto: " +nomeProduto);
            Console.WriteLine("Número de prestações: " + nPrestacoes);
            Console.WriteLine("Valor das prestações: " + Math.Round(valorPrestacoes,2));
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Para sair, aperte qualquer botão: ");
            Console.ReadLine();
        }
    }
}
