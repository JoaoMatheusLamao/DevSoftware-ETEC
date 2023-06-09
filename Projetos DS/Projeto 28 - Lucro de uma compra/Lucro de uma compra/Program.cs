using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucro_de_uma_compra
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeProduto, mensagem;
            double valorProduto, lucro;
            Console.WriteLine("Calculando lucro sobre vendas!!!");
            Console.WriteLine();
            Console.Write("Entre com o nome do produto a ser vendido: ");
            nomeProduto = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com o valor do produto: R$ ");
            valorProduto = double.Parse(Console.ReadLine());
            Console.WriteLine();
            if (valorProduto < 30)
            {
                lucro = valorProduto * 0.55;
                mensagem = "Lucro de 55%";
            }
            else
            {
                lucro = valorProduto * 0.40;
                mensagem = "Lucro de 40%";
            }
            Console.WriteLine("Nome do produto: " + nomeProduto);
            Console.WriteLine("Lucro: R$ " + Math.Round(lucro,2));
            Console.WriteLine(mensagem);
            Console.WriteLine();
            Console.Write("Para sair, aperte qualquer tecla...");
            Console.ReadLine();
        }
    }
}
