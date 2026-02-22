using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class AprendendoListas
    {
        public static void FazendoUmaLista()
        {
            List<int> Lista = new List<int>();

            Lista.Add(14);
            Lista.AddRange(1, 3, 22, 13);

            Console.WriteLine(String.Join(",", Lista));
        }
        
    }
}