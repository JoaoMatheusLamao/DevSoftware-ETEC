using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_eleitoral
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            Console.WriteLine("Classe eleitoral!!!");
            Console.WriteLine();
            Console.Write("Entre com seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com a sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine();
            /*Não eleitor*/
            if (idade < 16)
            {
                Console.WriteLine(nome + " não é um eleitor");
            }
            else
            {
                /*Eleitor Obrigatório*/
                if (idade >= 18 && idade <= 65)
                {
                    Console.Write(nome + " é um eleitor obrigatório");
                }
                else
                {
                    /*Eleitor facultativo entre 16 e 18 anos*/
                    if (idade >= 16 && idade < 18)
                    {
                        Console.Write(nome + " é um eleitor facultativo");
                    }
                    else
                    {
                        /*Eleitor facultati com mais de 65 anos*/
                        if (idade > 65)
                        {
                            Console.Write(nome + " é um eleitor facultativo");
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Para sair aperte qualquer tecla: ");
            Console.ReadLine();
        }
    }
}
