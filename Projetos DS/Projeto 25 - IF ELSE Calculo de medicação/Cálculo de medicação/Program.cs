using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_medicação
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso_paciente, gotas_medicação;
            int idade_paciente;
            string nome_paciente, sexo_paciente;
            Console.Write("Calculando doses de medicação");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Entre com o nome do paciente: ");
            nome_paciente = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com a idade do paciente: ");
            idade_paciente = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com o peso do paciente: ");
            peso_paciente = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Entre com o sexo do paciente: ");
            sexo_paciente = Console.ReadLine();
            Console.WriteLine();
            Console.Write("------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            if (idade_paciente <= 15)
            {
                gotas_medicação = peso_paciente * 0.5;
                Console.WriteLine("Paciente: " +nome_paciente);
                Console.WriteLine("Idade: " +idade_paciente + " anos");
                Console.WriteLine("Sexo: " +sexo_paciente);
                Console.WriteLine("Peso: " +peso_paciente +" kg");
                Console.WriteLine("Classificação: Infantil");
                Console.WriteLine("Quantidade de gotas indicada: " +gotas_medicação + " gotas");
            }
            else
            {
                gotas_medicação = peso_paciente * 1.2;
                Console.WriteLine("Paciente: " + nome_paciente);
                Console.WriteLine("Idade: " + idade_paciente +" anos");
                Console.WriteLine("Sexo: " + sexo_paciente);
                Console.WriteLine("Peso: " + peso_paciente + "kg");
                Console.WriteLine("Classificação: Adulto");
                Console.WriteLine("Quantidade de gotas indicada: " + gotas_medicação + " gotas" );
            }
            Console.WriteLine();
            Console.Write("------------------------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Para sair, aperte qualquer tecla: ");
            Console.ReadLine();
        }
    }
}
