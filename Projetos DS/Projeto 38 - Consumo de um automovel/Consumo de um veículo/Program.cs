using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo_de_um_veículo
{
    class Program
    {
        static void Main(string[] args)
        {
            string tpCarro;
            double km, consumo;
            consumo = 0;
            Console.WriteLine("Consumo de combustível de um veículo");
            Console.WriteLine();
            Console.Write("Digite quantos quilometros foram percorridos: ");
            km = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Entre com o tipode carro: \r\n A \r\n B \r\n C");
            tpCarro = Console.ReadLine();
            Console.WriteLine();
            if (tpCarro == "A" || tpCarro == "a")
            {
                consumo = km / 12;
            }
            else
            {
                if (tpCarro == "B" || tpCarro == "b")
                {
                    consumo = km / 9;
                }
                else
                {
                    if (tpCarro == "C" || tpCarro == "c")
                    {
                        consumo = km / 8;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("O consumo de gasolina, em litros, do automovel é: " + Math.Round(consumo,2));
            Console.ReadLine();
        }
    }
}
