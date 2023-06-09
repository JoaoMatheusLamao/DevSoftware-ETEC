using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicial_do_cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeCliente, inicial, mensagem;
            double vConta, desconto, vFinal;
            Console.WriteLine("Inicial do cliente");
            Console.WriteLine();
            Console.Write("Digite o nome do cliente: ");
            nomeCliente = Console.ReadLine();
            inicial = nomeCliente.Substring(0, 1);
            Console.WriteLine();
            Console.Write("Digite o valor final da conta: ");
            vConta = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine();
            if (inicial == "A" || inicial == "a")
            {
                desconto = 0.30;
                mensagem = "Seu desconto é de 30%";
            }
            else
            {
                if (inicial == "D" || inicial == "d") 
                {
                    desconto = 0.30;
                    mensagem = "Seu desconto é de 30%";
                }
                else
                {
                    if (inicial == "M" || inicial == "m")
                    {
                        desconto = 0.30;
                        mensagem = "Seu desconto é de 30%";
                    }
                    else
                    {
                        if (inicial == "S" || inicial == "s")
                        {
                            desconto = 0.30;
                            mensagem = "Seu desconto é de 30%";
                        }
                        else
                        {
                            desconto = 0;
                            mensagem = "Que pena! Nesta semana o desconto não é para o seu nome; \r\nMas continue nos prestigiando. Sua vez chegará!!!";
                        }
                    }
                }
            }
            vFinal = vConta - (vConta * desconto);
            Console.WriteLine("Cliente: " +nomeCliente);
            Console.WriteLine();
            Console.WriteLine("inicial: " + inicial);
            Console.WriteLine();
            Console.WriteLine(mensagem);
            Console.WriteLine();
            Console.WriteLine("Valor final da conta: " + Math.Round(vFinal,2));
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Para sair, digite qualquer tecla...");
            Console.ReadLine();
        }
    }
}
