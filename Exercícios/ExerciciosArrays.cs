using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Exercícios
{
    public class ExerciciosArrays
    {
        public static void ArmazemDeInfomacoes()
        {
            Console.Write("Digite Quantos Itens você deseja adicionar ao Array: ");
            int quantidadeInicial = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[quantidadeInicial];

            for(int cont = 0; cont < array.Length; cont++)
            {
                Console.Write("Informe os dados que quer adicionar no array: ");
                string? dadosArray = Console.ReadLine();
                array[cont] = dadosArray ?? "Vázio";
            }

            Console.WriteLine(String.Join(",",array));
        }
    }
}