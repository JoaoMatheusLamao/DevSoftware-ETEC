using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Média_do_aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            float M1, M2, M3, M4, MF;
            string NOME;
            Console.Write("Média anual");
            Console.WriteLine();
            Console.Write("Entre com o nome do aluno: ");
            NOME = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com a média do 1º bimestre: ");
            M1 = float.Parse(Console.ReadLine());
            Console.Write("Entre com a média do 2º bimestre: ");
            M2 = float.Parse(Console.ReadLine());
            Console.Write("Entre com a média do 3º bimestre: ");
            M3 = float.Parse(Console.ReadLine());
            Console.Write("Entre com a média do 4º bimestre: ");
            M4 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Calculando média final...");
            MF = (M1 + M2 + M3 + M4) / 4;
            Console.WriteLine();
            Console.Write("Aluno: " + NOME);
            Console.WriteLine();
            Console.Write("A média final do aluno "+NOME);
            Console.Write(" é: " + MF);
            Console.WriteLine();
            Console.Write("Para sair, digite qualquer tecla!");
            Console.ReadLine();
        }
    }
}
