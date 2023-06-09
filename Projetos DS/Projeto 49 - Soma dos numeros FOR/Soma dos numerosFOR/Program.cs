using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_dos_numerosFOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, resultado;
            resultado = 0;
            Console.WriteLine("Calculando a soma de todos os números menores que 200 e divisíveis por 4");
            Console.WriteLine();
            Console.WriteLine("Este programa calculará a soma de todos os números menores que 200 divisiveis por 4.");
            Console.Write("Para iniciar, precione qualquer tecla...");
            Console.ReadLine();
            for (i = 1; i <= 199; i++)
            {
                if ((i % 4) == 0)
                {
                    resultado = resultado + i;
                }
            }
            Console.WriteLine("O resultado é: " + resultado);
            Console.ReadLine();
        }
    }
}
