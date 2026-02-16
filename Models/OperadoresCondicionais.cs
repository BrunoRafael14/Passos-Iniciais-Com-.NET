using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class OperadoresCondicionais
    {
        public static void Condicionais01(int quantidadeNecessaria)
        {
            int quantidade = 10;


            if (quantidade == 0)
            {
                Console.WriteLine("Pedido Inválido");
            }
            else if (quantidade >= quantidadeNecessaria)
            {
                Console.WriteLine("Pedido Feito");
            }
            else
            {
                Console.WriteLine("Não é possível fazer Pedido");
            }
        }

        public static void SwitchCase(int numero)
        {
            switch (numero)
            {
                case 0:
                case 7:
                case 14:
                case 23:
                case 24:
                    Console.WriteLine("Número Brabo");
                    break;
                
                default:
                    Console.WriteLine("Paia");
                    break;
            }
        }
    }
}