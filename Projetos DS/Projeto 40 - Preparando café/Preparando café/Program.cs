using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparando_café
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd_xicaras, qtd_agua, qtd_po;
            string tp_cafe_menu, tp_cafe;

            qtd_po = 0;
            Console.WriteLine("Enunciado: ");
            Console.WriteLine();
            Console.WriteLine("Com base na tabela abaixo, elabore um programa c# que calcule a quantidade de água e pó necessários para " +
                "\r\na produção do café.\r\n" +
                "Sabe-se que cada xícara tem 180 ml de água.");
            Console.WriteLine();
            Console.WriteLine("Forte --- 3 colheres (sopa) de café por xícara;");
            Console.WriteLine("Normal --- 2 colheres (sopa) de café por xícara;");
            Console.WriteLine("Fraco --- 1 colher (sopa) de café por xícara;");
            Console.WriteLine();
            Console.WriteLine("Programa: ");
            Console.WriteLine();

            Console.Write("Quantas xícaras serão feitas? ");
            qtd_xicaras = int.Parse(Console.ReadLine());
            qtd_agua = qtd_xicaras * 180;
            Console.WriteLine();
            Console.WriteLine("Observe a tabela abaixo: ");
            Console.WriteLine();
            Console.WriteLine("1 --- Forte;");
            Console.WriteLine("2 --- Normal;");
            Console.WriteLine("3 --- Fraco;");
            Console.WriteLine();
            Console.Write("Qual o tipo de café desejado: ");
            tp_cafe_menu = Console.ReadLine();
            Console.WriteLine();
            if (tp_cafe_menu == "1" || tp_cafe_menu == "Forte")
            {
                qtd_po = 3 * qtd_xicaras;
                tp_cafe = "Forte";
            }
            else
            {
                if (tp_cafe_menu == "2" || tp_cafe_menu == "Normal")
                {
                    qtd_po = 2 * qtd_xicaras;
                    tp_cafe = "Normal";
                }
                else
                {
                    if (tp_cafe_menu == "3" || tp_cafe_menu == "Fraco")
                    {
                        qtd_po = 1 * qtd_xicaras;
                        tp_cafe = "Fraco";
                    }
                }
            }
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Exibindo conclusão: ");
            Console.WriteLine();
            Console.WriteLine("Quantidade de xícaras: " + qtd_xicaras);
            Console.WriteLine("Quantidade de água utilizada: " + qtd_agua + " ml");
            Console.WriteLine("Tipo de café: " + tp_cafe_menu);
            Console.WriteLine("Quantidade de pó usado: " + qtd_po + " colheres de sopa");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Para sair, digite qualquer tecla...");
            Console.ReadLine();
        }
    }
}
