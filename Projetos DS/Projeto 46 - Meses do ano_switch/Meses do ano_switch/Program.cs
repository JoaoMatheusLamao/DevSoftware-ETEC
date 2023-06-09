using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meses_do_ano_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes_num;
            string mes;
            Console.WriteLine("Meses do ano - SWITCH");
            Console.WriteLine();
            Console.Write("Digite o número equivalente ao mês desejado: ");
            mes_num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (mes_num)
            {
                case 1:
                    mes = "Janeiro";
                    break;
                case 2:
                    mes = "Fevereiro";
                    break;
                case 3:
                    mes = "Março";
                    break;
                case 4:
                    mes = "Abril";
                    break;
                case 5:
                    mes = "Maio";
                    break;
                case 6:
                    mes = "Junho";
                    break;
                case 7:
                    mes = "Julho";
                    break;
                case 8:
                    mes = "Agosto";
                    break;
                case 9:
                    mes = "Setembro";
                    break;
                case 10:
                    mes = "Outubro";
                    break;
                case 11:
                    mes = "Novembro";
                    break;
                case 12:
                    mes = "Dezembro";
                    break;
                default:
                    mes = "nenhum mês. Repita a operação";
                    break;
            }
            Console.WriteLine("O número inserido corresponde a " + mes);
            Console.WriteLine();
            Console.Write("Para sair aperte qualquer tecla...");
            Console.ReadLine();
        }
    }
}
