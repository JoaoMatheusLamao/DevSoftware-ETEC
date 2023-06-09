using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reajuste_salarial_IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeFuncionario, cargoFuncionario, mensagem;
            float salario, salarioReajustado;
            Console.WriteLine("Reajuste Salarial - IF ELSE");
            Console.WriteLine();
            Console.Write("Entre com o nome do funcionário: ");
            nomeFuncionario = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com o cargo do funcionário: ");
            cargoFuncionario = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com o salario a ser reajustado: R$ ");
            salario = float.Parse(Console.ReadLine());
            Console.WriteLine();
            if (salario >= 1500)
            {
                salarioReajustado = salario + (salario * 15 / 100);
                mensagem = "O reajuste salarial foi de 15%";
            }
            else
            {
                salarioReajustado = salario + (salario * 18 / 100);
                mensagem = "O reajuste salarial foi de 18%";
            }
            Console.WriteLine("Nome do funcionário: " + nomeFuncionario);
            Console.WriteLine("Cargo do funcionário: " +cargoFuncionario);
            Console.WriteLine(mensagem);
            Console.WriteLine("Salário reajustado: R$ " + Math.Round(salarioReajustado,2));
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Para sair, aperte qualquer tecla: ");
            Console.ReadLine();
        }
    }
}
