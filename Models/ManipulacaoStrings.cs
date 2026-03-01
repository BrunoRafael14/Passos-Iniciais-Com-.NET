using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class ManipulacaoStrings
    {
        public static void Concatenacao()
        {
            Console.WriteLine("Testando" + "Concatenação");
            Console.WriteLine("Também Funciona para Números ? " + 4);
        }

        public static void Interpolacao()
        {
            string Nome = "Atratonixo";
            Console.WriteLine($"Testando interpolação com o nome {Nome}");
        }
    }
}