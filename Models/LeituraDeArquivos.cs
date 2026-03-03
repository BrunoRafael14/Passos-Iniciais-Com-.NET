using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class LeituraDeArquivos
    {
        public static void LendoArquivo()
        {
            try

            {

                string[] linhas = File.ReadAllLines("Exercícios/LeituraDeArquivos/Arquivo.txt");

                foreach(string linha in linhas)

                {

                    Console.WriteLine(linha);

                }

            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine($"Arquivo Não encontrado. {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ocorreu uma Exceção. {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finalmente terminou");
            }
        }
    }
}