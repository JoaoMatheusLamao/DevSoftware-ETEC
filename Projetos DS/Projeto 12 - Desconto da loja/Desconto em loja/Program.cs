using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desconto_em_loja
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, valorComDesconto, desconto;
            string nome;
            Console.Write("Calculando desconto !!!");
            Console.WriteLine();
            Console.Write("Entre com o nome do cliete: ");
            nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com o valor comprado: R$ ");
            valor = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Calculando");
            desconto = valor * 0.09;
            valorComDesconto = valor - desconto;
            Console.WriteLine();
            Console.Write("Cliente: " + nome);
            Console.WriteLine();
            Console.Write("Total (com desconto): R$ " + valorComDesconto);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Para sair, pressione qualquer tecla!!!");
            Console.ReadLine();
        }
    }
}
