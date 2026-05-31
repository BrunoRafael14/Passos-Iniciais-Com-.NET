using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Passos_iniciais_com_.NET.Models.ExceptionsKek;

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

        public static void VendoThrow1()
        {
            throw new Exception("Testando Throw");
        }
        public static void VendoThrow2()
        {
            VendoThrow3();
        }
        public static void VendoThrow3()
        {
            VendoThrow1();
        }


        public static void TestandoExceptionsPersonalizadas()
        {
            Console.WriteLine("Digite o nome: ");
            string? nome = Console.ReadLine();
            if (nome != "Alexiano")
            {
                throw new NomeErradoKekException("Nome está errado");
            }
        }
    }
}