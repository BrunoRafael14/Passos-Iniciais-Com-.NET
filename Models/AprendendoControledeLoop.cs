using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class AprendendoControledeLoop
    {
        public static void TestandoBreak()
        {
            string[] status = new string[] {"Certo", "Certo", "Erro", "Certo"};

            for (int i = 0; i < status.Length; i++)
            {
                if (status[i] == "Erro")
                {
                    Console.WriteLine("Sistema apresentou erro");
                    break;
                }

                Console.WriteLine(status[i]);
            }
        }

        public static void TestandoContinue()
        {
            string[] nomes = new string[] {"Bruno", "Alexiano", " ", "Joshua"};

            for (int i = 0; i < nomes.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(nomes[i]))
                {
                    continue;
                }

                Console.WriteLine(nomes[i]);
            }
        }
    }
}