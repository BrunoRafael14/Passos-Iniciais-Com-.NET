using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class EstruturasRepeticao
    {
        public static void For(int iterador)
        {
            for(int contador = 0; contador <= 10; contador+= iterador)
            {
                Console.WriteLine($"Contando Carneiros, atualmente {contador} carneiros");
            }
        }

        public static void While()
        {
            int contador = 10;
            while(contador >= 0)
            {
                Console.WriteLine($"Estou me livrando dos lobitos no meu curral, restam {contador}");
                contador--;
            }
        }

        public static void DoWhile()
        {
            int quantidadeProdutosCarrinho = 0, quantidadeAdicionarCarrinho = 0;
            string? resposta;

            do
            {
                Console.WriteLine("Digite quantos carneiros você quer comprar (0 para parar)");
                quantidadeAdicionarCarrinho = Convert.ToInt32(Console.ReadLine());
                quantidadeProdutosCarrinho += quantidadeAdicionarCarrinho;
                Console.WriteLine($"Atualmente {quantidadeProdutosCarrinho} Carneiros no carrinho");
                Console.WriteLine("Deseja Adicionar mais carneiros ?");
                resposta = Console.ReadLine();
            } while(resposta == "sim");
        }
    }
}