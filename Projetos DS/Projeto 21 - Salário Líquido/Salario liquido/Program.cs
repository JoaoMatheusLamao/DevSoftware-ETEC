using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario_liquido
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome_funcionario, cargo_funcionário;
            float horas_trabalhadas, valor_hora, percentual_descontos, descontos, salario_liq, salario_bruto;
            Console.Write("Calculando o salário líquido de um funcionário");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Entre com o nome do funcionário: ");
            nome_funcionario = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com o cargo exercído pelo funcionário: ");
            cargo_funcionário = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com o valor das horas de trabalho do respectivo funcionário: R$ ");
            valor_hora = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com o total de horas trabalhadas pelo funcionário: ");
            horas_trabalhadas = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com o percentual que é descontado do salário do funcionário: ");
            percentual_descontos = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Calculando.....");
            Console.WriteLine();
            Console.Write("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            salario_bruto = horas_trabalhadas*valor_hora;
            descontos = salario_bruto * (percentual_descontos / 100);
            salario_liq = salario_bruto - descontos;
            if (salario_liq >= 1000)
            {
                Console.WriteLine();
                Console.WriteLine("Funcionário: " + nome_funcionario);
                Console.WriteLine("Cargo: " +cargo_funcionário);
                Console.WriteLine("Total de horas trabalhadas: " +horas_trabalhadas);
                Console.WriteLine("Valor por hora trabalhada: R$ " +valor_hora);
                Console.Write("Percentual de desconto: " +percentual_descontos);
                Console.Write("%");
                Console.WriteLine();
                Console.WriteLine("Salário Líquido: R$ " +salario_liq);
            }
            Console.WriteLine();
            Console.Write("-------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Para sair aperte qualquer tecla...");
            Console.ReadLine();
        }
    }
}
