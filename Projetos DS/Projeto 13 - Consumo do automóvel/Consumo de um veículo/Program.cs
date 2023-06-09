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
            double velocidadeMedia, tempo, distancia, consumo;
            Console.Write("Consumo de um automóvel");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Informe a velocidade média, em Km/h, do veículo: ");
            velocidadeMedia = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Informe o tempo total percorrido pelo carro, em horas: ");
            tempo = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Calculando...");
            Console.WriteLine();
            distancia = velocidadeMedia * tempo;
            consumo = distancia /12;
            Console.WriteLine();
            Console.Write("A distância percorrida foi: " + distancia);
            Console.Write(" km");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("O tempo gasto foi de: " + tempo);
            Console.Write(" horas");
            Console.WriteLine();
            Console.Write("A velocidade média do veículo foi de: " + velocidadeMedia);
            Console.Write(" Km/h");
            Console.WriteLine();
            Console.Write("O consumo total do veículo, em litros, foi: " +consumo);
            Console.WriteLine();
            Console.WriteLine("Para sair, aperte qualquer tecla!!!");
            Console.ReadLine();
        }
    }
}
