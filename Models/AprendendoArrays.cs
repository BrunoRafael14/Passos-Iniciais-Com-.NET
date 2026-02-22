using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class AprendendoArrays
    {
        public static void Array()
        {
            int[] numeros = new int[2];
            numeros[0] = 13;
            numeros[1] = 231;
            Console.WriteLine("Digite o índice que você quer verificar");
            int indice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O valor do índice {indice} é {numeros[indice - 1]}");
        }

        public static void PercorrendoArray()
        {
            string[] nomes = new string[] {"Bruno","Josivaldo","Alexiano","Antunes","Antonio"};
            foreach (string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }

        public static void AuterandoQuantidadeArray()
        {
            int[] arrayNumeros = new int[] {14, 13, 22};
            Console.WriteLine(String.Join(", ", arrayNumeros));


            System.Array.Resize(ref arrayNumeros, arrayNumeros.Length + 3);
            Console.WriteLine(String.Join(", ", arrayNumeros));
        }

        public static void CopiandoArray()
        {
            int[] arrayNumeros = new int[] {14, 13, 22};
            int[] arrayCopia = new int[arrayNumeros.Length];
            System.Array.Copy(arrayNumeros, arrayCopia, 3);

            Console.WriteLine(String.Join(",", arrayCopia));
        }
    }
}