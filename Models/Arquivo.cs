using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TesteDotNet.Models
{
    class Arquivo
    {

        public void CriarAlterarArquivo(string nomeDoArquivo, string tex)
        {
            if (File.Exists(nomeDoArquivo))
            {
                using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(nomeDoArquivo, true))
                {
                    file.WriteLine(tex);
                }
            }
            else
            {
                File.WriteAllText(nomeDoArquivo, tex);
                Console.WriteLine("Arquivo criado");
                string texto = File.ReadAllText("\n"+nomeDoArquivo);

                Console.WriteLine("Conteudo do arquivo: " + texto);
            }

        }

        public void MostrarArquivo(string nomeDoArquivo)
        {
            if (File.Exists(nomeDoArquivo))
            {
                Stream entrada = File.Open(nomeDoArquivo, FileMode.Open);
                StreamReader leitor = new StreamReader(entrada);
                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    Console.WriteLine(linha);
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                entrada.Close();
            }
        }
    }
}
