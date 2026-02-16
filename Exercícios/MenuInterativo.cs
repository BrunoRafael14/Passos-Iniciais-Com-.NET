using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Exercícios
{
    public class MenuInterativo
    {
        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("Opções: \n 1- Fazer Pix \n 2- Fazer Compra \n 3- Doar para cuidados aos Pinguins \n 4- Sair");
                int resposta = Convert.ToInt32(Console.ReadLine());
                switch (resposta)
                {
                    case 1:
                        Console.WriteLine("Você fez um Pix");
                        break;
                    case 2:
                        Console.WriteLine("Escolha o Produto");
                        break;
                    case 3:
                        Console.WriteLine("Obrigado pela doação");
                        break;
                    case 4:
                        Console.WriteLine("Adeus");
                        Environment.Exit(0);
                        break;
            
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }
        }
    }
}