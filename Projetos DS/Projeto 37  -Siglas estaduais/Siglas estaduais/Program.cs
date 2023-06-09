using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siglas_estaduais
{
    class Program
    {
        static void Main(string[] args)
        {
            string sigla, mensagem;
            Console.WriteLine("Siglas estaduais");
            Console.WriteLine();
            Console.Write("Digite a sigla do seu estado: ");
            sigla = Console.ReadLine();
            Console.WriteLine();
            if (sigla == "RJ" || sigla == "rj")
            {
                mensagem = "Carioca";
            }
            else
            {
                if (sigla == "SP" || sigla == "sp")
                {
                    mensagem = "Paulista";
                }
                else
                {
                    if (sigla == "MG" || sigla == "sp")
                    {
                        mensagem = "Mineiro";
                    }
                    else
                    {
                        mensagem = "Outros estados";
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("A sigla digitada refere-se à: " + mensagem);
            Console.ReadLine();
        }
    }
}
