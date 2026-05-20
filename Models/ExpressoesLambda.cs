using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class ExpressoesLambda
    {
        public static void TestandoExpressoesLambda()
        {
            List<int> ListaNumeros = new List<int>{1, 3, 14, 22};
            List<int> ListaNumerosPares = new List<int>();

            Func<int, bool> verPar = x => x % 2 == 0;

            foreach (var i in ListaNumeros)
            {
                if(verPar(i) == true)
                {
                    ListaNumerosPares.Add(i);
                }
            }

            Console.WriteLine(ListaNumerosPares.Count);
        }
    }
}