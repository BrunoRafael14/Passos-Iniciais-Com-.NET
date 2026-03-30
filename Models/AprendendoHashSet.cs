using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class AprendendoHashSet
    {
        static List<int> numeros = new List<int> {14, 12, 42, 15};
        static HashSet<int> conjunto = new HashSet<int>(numeros);

        public static void VerificandoHashSet()
        {
            foreach (int n in conjunto)
            {
                Console.WriteLine(n);
            }   
        }

        public static void AdicionandoNúmeros(int numero)
        {
            conjunto.Add(numero);
        }
    }
}