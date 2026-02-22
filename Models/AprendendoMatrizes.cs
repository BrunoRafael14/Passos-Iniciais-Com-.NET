using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class AprendendoMatrizes
    {
        public static void CriandoMatrizBidimensional()
        {
            string[,] matrizBi = new string[3,2];
            matrizBi = new string[,]{{"Bruno","19 anos"}, {"Alexiano", "23 anos"}, {"Xerena", "18 anos"}};

            for(int i = 0; i < matrizBi.GetLength(0); i++)
            {
                for (int j = 0; j < matrizBi.GetLength(1); j++)
                {
                    Console.Write(matrizBi[i,j] + ", ");
                }
                Console.WriteLine();
            }
        }
    }
}