using System;
using TesteDotNet.Models;
using TesteDotNet.View;

namespace TesteDotNet
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Menu menu = new Menu();
                string nomeArquivo, text;


                Console.WriteLine("Seja bem vindo!!!");
                int num1, num2, op;

                Console.WriteLine("Digite os dois numeros: ");
                string[] linha = Console.ReadLine().Split(' ');
                num1 = int.Parse(linha[0]);
                num2 = int.Parse(linha[1]);
                
                Console.Write("\nEscolha a operação: ");

                Mensagem();
                op = Convert.ToInt32(Console.ReadLine());

                while (op != 0)
                {
                    if (op == 5 || op == 6)
                    {
                        Console.WriteLine("Digite o nome do arquivo e o texto: ");
                        string[] linhas = Console.ReadLine().Split(' ');
                        nomeArquivo = (linha[0]);
                        text = (linha[1]);


                        menu.Opcoes(op, num1, num2, nomeArquivo, text);
                        Mensagem();
                        op = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        menu.Opcoes(op, num1, num2, null, null);
                        Mensagem();
                        op = Convert.ToInt32(Console.ReadLine());
                    }
                }

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: " + ex);
            }


        }
        private static void Mensagem()
        {
            Console.WriteLine("\n1) Soma \t\t2) Subtração \n3) Divisão \t4) Multiplicação \n5) Ler arquivo \t\t6) Mostrar arquivo \n0) Para finalizar operação");
        }
    }
}
