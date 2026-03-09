using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class AprendendoDicionarios
    {
        public static void Dicionarios()
        {
            Dictionary<string, int> pessoas = new Dictionary<string, int>();

            pessoas.Add("teste", 21);

            Console.Write("Informe seu nome: ");
            string? nome = Console.ReadLine();
            Console.Write("Informe sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            pessoas.Add(nome ?? "nada", idade);

            Console.WriteLine($" Nome: {String.Join(",", pessoas.Keys)} \n Idade: {String.Join(",", pessoas.Values)}");
            
        }
    }
}