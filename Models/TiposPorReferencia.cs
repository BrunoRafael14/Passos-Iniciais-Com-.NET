using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class TiposPorReferencia
    {
        public static void TestandoTiposPorReferencia()
        {
            var list1 = new List<string>{"Ola", "Testando", "Ziriguidun"};
            var list2 = list1;
            list2.Add("Pampovini");
            foreach(var n in list1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine(" Teste 2 ".PadLeft(14, '=').PadRight(19, '='));
            foreach(var n in list2)
            {
                Console.WriteLine(n);
            }
        }
    }
}