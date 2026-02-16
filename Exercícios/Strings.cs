using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Exercícios
{
    public class Strings
    {

        public void exercicio01()
        {
            //Impressões Iniciais no console

            Console.WriteLine("This is the first line");
            Console.WriteLine("This is the second line.");
            Console.Write(2);
        }
        public void exercicio02()
        {
            // Exercício básico de utilização de variáveis
            string nome = "Bob";
            int idade = 14;
            double money = 152.25;

            Console.WriteLine( $"Ola {nome}, vejo que você tem {idade} anos, suas compras deram {money} reais");
        }

        public void exercicio03()
        {
            //Testando concatenação
            char letra = 'a';
            string palavra = "test";
            string palavraCompleta = palavra + letra;
            Console.WriteLine(palavraCompleta);
        }
    }
}