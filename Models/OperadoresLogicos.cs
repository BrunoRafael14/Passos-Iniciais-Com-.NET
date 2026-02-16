using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class OperadoresLogicos
    {
        public static void Or(int idade, bool autorizacao)
        {
            if (idade >= 18 || autorizacao)
            {
                Console.WriteLine("Pode Raparigar");
            }
            else
            {
                Console.WriteLine("Não Pode Raparigar");
            }
        }

        public static void And(int dinheiro, bool vontadeComerPacoca)
        {
            decimal pacoca = 1.5M;

            if (dinheiro >= pacoca && vontadeComerPacoca)
            {
                Console.WriteLine("Toma a Paçoca Mindigo");
            }
            else if (dinheiro < pacoca && vontadeComerPacoca)
            {
                Console.WriteLine("Vai passar fome Mindigo");
            }
            else
            {
                Console.WriteLine("Vaza daqui então Mindigo");
            }
        }

        public static void Not(bool TemDiabetes)
        {
            if (!TemDiabetes)
            {
                Console.WriteLine("Pode Comer Doce");
            }
            else
            {
                Console.WriteLine("Não pode Comer Doce");
            }
        }       
    }
}