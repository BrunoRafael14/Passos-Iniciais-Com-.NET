using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

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

        public static void StringBuilderTeste()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Olá ");
            sb.Append("Mundo");

            Console.WriteLine(sb.ToString());

            sb.Append(" Coconut");
            Console.WriteLine(sb.ToString());
        }
    }
}