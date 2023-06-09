using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptidão_para_vaga_de_emprego2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float idade;
            Console.Write("Estrutura IF - Verificando se o candidato tem mais de 21 anos");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Entre com nome do candidato: ");
            nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com a idade do candidato: ");
            idade = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine();
            if (idade >= 20)
            {
                Console.WriteLine("O candidato " + nome + " está apto para a vaga de emprego!!!");
            }
            else
            {
                Console.WriteLine("O candidato " + nome + " NÂO está apto para vaga de emprego!!!");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Para sair, aperte qualqer tecla!");
            Console.ReadLine();
        }
    }
}
