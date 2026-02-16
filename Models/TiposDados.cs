using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class TiposDados
    {

        public static void MostrarDados()
        {
            // Tipos de Dados: Char
            Console.WriteLine('t');


            // Tipos de Dados: String
            Console.WriteLine("Testando string");

            // Tipos de Dados: Inteiro
            Console.WriteLine(3);

            // Tipos de Dados: Double
            double numero = 4.2199234234;
            Console.WriteLine(numero);

            // Tipos de Dados: Booleano
            Console.WriteLine(true);

            // Tipos de Dados: Implícito
            var nome = "Bruno";
            Console.WriteLine(nome);

            // Tipos de Dados: DateTime
            DateTime agora = DateTime.Now.AddDays(15);
            Console.WriteLine(agora);
        }

        public static void Conversao()
        {
            //Testando conversão implícita de tipos
            int conversaoChar = 'c';
            Console.WriteLine(conversaoChar);
        }
    }
}