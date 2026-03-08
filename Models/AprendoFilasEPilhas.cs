using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class AprendoFilasEPilhas
    {
        public static void Filas()
        {
            Queue<int> numeros = new Queue<int>();
            while(true){
                Console.Write("Informe um número para adicionar a fila: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                numeros.Enqueue(numero);
                Console.Write("Adicionar mais números? (s/n): ");
                string? resposta = Console.ReadLine();
                if (resposta != "s"){
                    break;
                }

            }
            Console.WriteLine(String.Join(",", numeros));            
        }

        public static void Pilhas()
        {
            
        }
    }
}