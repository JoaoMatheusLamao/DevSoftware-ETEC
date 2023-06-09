using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Média_do_aluno__IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome_aluno;
            float nota_1, nota_2, nota_3, nota_4, media;
            Console.Write("Verificando aprovação dos alunos - IF ELSE");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Entre com o nome do alunos: ");
            nome_aluno = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Digite a primeira nota: ");
            nota_1 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite a segunda nota: ");
            nota_2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite a terceira nota: ");
            nota_3 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite a quarta nota: ");
            nota_4 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Calculando...");
            media = (nota_1 + nota_2 + nota_3 + nota_4) / 4;
            if (media >= 6.0)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("ALUNO APROVADO!!!");
                Console.WriteLine();
                Console.WriteLine("Média final: " + media);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("ALUNO REPROVADO!!!");
                Console.WriteLine();
                Console.WriteLine("Média final: " + media);
                Console.WriteLine();
            }
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Para sair, aperte qualquer tecla!");
            Console.ReadLine();
        }
    }
}
