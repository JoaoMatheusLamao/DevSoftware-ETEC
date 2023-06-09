using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOME, RUA_END, NUM_END, BAIRRO_END, CID_END, CPF, RG, SERIE, ANO, SEM, CURSO, DN, E_END, CEP_END;
            Console.WriteLine("Cadastro de Alunos - Escola ABC");
            Console.WriteLine();
            Console.Write("Entre com o nome do aluno: ");
            NOME = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Endereço do aluno - Entre com a rua: ");
            RUA_END = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Endereço do aluno - Entre com a número: ");
            NUM_END = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Endereço do aluno - Entre com o bairro: ");
            BAIRRO_END = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Endereço do aluno - Entre com a cidade: ");
            CID_END = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Endereço do aluno - Entre com o estado: ");
            E_END = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Endereço do aluno - Entre com o CEP: ");
            CEP_END = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com o CPF do aluno: ");
            CPF = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com o RG do aluno: ");
            RG = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com a série desejada (1ª à 8ª): ");
            SERIE = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com o ano da matrícula: ");
            ANO = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com o semestre da matrícula (1º ou 2º): ");
            SEM = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com o curso desejado: ");
            CURSO = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com data de nascimento do aluno: ");
            DN = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("RELATÓRIO");
            Console.WriteLine("Nome do aluno: "+NOME);
            Console.WriteLine("CPF: "+CPF);
            Console.WriteLine("Serie: "+ SERIE,"ª");
            Console.Write("Endereço: Rua " + RUA_END);
            Console.Write(", nº " + NUM_END);
            Console.Write(", " + BAIRRO_END);
            Console.Write(", " +CID_END);
            Console.WriteLine(" - " + E_END);
            Console.WriteLine("CEP: " + CEP_END);
            Console.WriteLine("Data de nascimento: "+ DN);
            Console.WriteLine("Curso escolhido: " +CURSO);
            Console.WriteLine("Semestre e ano da matrícula: "+ SEM, "_"+ ANO);
            Console.WriteLine();
            Console.WriteLine("Para sair, aperte qualquer tecla!");
            Console.ReadLine();
        }
    }
}
