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
            Console.WriteLine(agora.ToString("dd/MM/yyyy HH:mm"));
        }

        public static void ConversaoImplicita()
        {
            //Testando conversão implícita de tipos
            int conversaoChar = 'c';
            Console.WriteLine(conversaoChar);
        }

        public static void ConversaoExplicita()
        {
            Console.WriteLine("Informe o valor a ser convertido para Int");
            
            string? valorConversao = Console.ReadLine() ?? "Valor Não Informado";
            var tipoAnterior = valorConversao!.GetType();
            int valorConvertido = int.Parse(valorConversao);
            var tipoConvertido = valorConvertido.GetType();

            Console.WriteLine($" Valor Digitado: {valorConversao} \n Tipo Original: {tipoAnterior} \n Tipo Convertido: {tipoConvertido}");
        }
    }
}