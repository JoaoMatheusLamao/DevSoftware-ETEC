using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peso_ideal
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sexo, sexoMenu;
            double altura, peso;
            Console.WriteLine("Calculando o peso ideal");
            Console.WriteLine();
            Console.Write("Entre com o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Qual seu sexo: \r\n 1 - Masculino \r\n 2 - Feminino");
            sexoMenu = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com a sua altura: ");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            if (sexoMenu == "1" || sexoMenu == "Masculino")
            {
                peso = (72.7 * altura) - 58;
                sexo = "Masculino";
            }
            else
            {
                peso = (62.1 * altura) - 44.7;
                sexo = "Feminino";
            }
            Console.WriteLine(nome + ", do sexo " + sexo + ", tem como peso ideal: " +Math.Round(peso,2));
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Para sair, aperte qualquer tecla");
            Console.ReadLine();
        }
    }
}
