using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class Formatacoes
    {
        public static void ValoresMonetarios()
        {
            decimal valor = 82.30M;

            Console.WriteLine($"{valor:C}");
        }
    }
}