using System;

namespace Cadastro_de_Clientes
{
    class Program
    {
        static void Main(string[] args)
        {
            string NOME, RUA, NUM, BAIRRO, CIDADE, ESTADO, CPF, RG, EC, DN, PROFISSAO;
            Console.WriteLine("Cadastro de clientes!");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Digite seu nome: ");
            NOME = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Endereço - Digite o nome da sua rua: ");
            RUA = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Endereço - Digite o número da sua casa: ");
            NUM = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Endereço - Digite seu bairro: ");
            BAIRRO = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Endereço - Digite seu cidade: ");
            CIDADE = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Endereço - Digite seu estado: ");
            ESTADO = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Digite seu CPF: ");
            CPF = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Digite seu RG: ");
            RG = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Entre com seu estado civíl: ");
            EC = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Digite sua profissão: ");
            PROFISSAO = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Digite sua data de nascimento: ");
            DN = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Relatório: ");
            Console.WriteLine("Nome do Cliente: " + NOME);
            Console.WriteLine("Endereço: Rua "+RUA);
            Console.WriteLine("Endereço: Nº " + NUM);
            Console.WriteLine("Endereço: Bairro " + BAIRRO);
            Console.WriteLine("Endereço: Cidade " + CIDADE);
            Console.WriteLine("Endereço: Estado " + ESTADO);
            Console.WriteLine("CPF: " + CPF);
            Console.WriteLine("RG: " + RG);
            Console.WriteLine("Estado civíl: " + EC);
            Console.WriteLine("Data de nascimento: " + DN);
            Console.WriteLine("Profissão: " + PROFISSAO);
            Console.WriteLine();
            Console.WriteLine("Para sair, aperte qualquer tecla!");
        }
    }
}
