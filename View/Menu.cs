using System;
using System.Collections.Generic;
using System.Text;
using TesteDotNet.Models;

namespace TesteDotNet.View
{
    public class Menu
    {

        public void Opcoes(int op, int num1, int num2, string nomeArquivo=null, string txt=null)
        {
            Calc calc = new Calc();

            switch (op)
            {
                case 1:
                    Mensagem(calc.Sum(num1, num2));
                    break;
                case 2:
                    Mensagem(calc.Sub(num1, num2));
                    break;
                case 3:
                    Mensagem(calc.Div(num1, num2));
                    break;
                case 4:
                    Mensagem(calc.Multi(num1, num2));
                    break;
                case 5:
                    arquivoLer(nomeArquivo, txt);
                    break;
                case 6:
                    MostrarArquivo(nomeArquivo);
                    break;
                default:
                    break;
            }
        }

        private void MostrarArquivo(string nome)
        {
            Arquivo arquivos = new Arquivo();
            arquivos.MostrarArquivo(nome);
        }

        private void arquivoLer(string nome, string text)
        {
            Arquivo arquivo = new Arquivo();

            arquivo.CriarAlterarArquivo(nome, text);
        }

        private void Mensagem(Double result)
        {
            Console.WriteLine("O resultado é:" + result);
        }
    }
}

