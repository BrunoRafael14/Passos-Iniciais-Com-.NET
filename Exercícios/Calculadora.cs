using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Exercícios
{
    public class Calculadora
    {
        public static void Calcular(int x, int y, string operacao)
        {
            switch (operacao)
            {
                case "+":
                    Console.WriteLine($"Resposta é {x+y}");
                    break;
                case "-":
                    Console.WriteLine($"Resposta é {x-y}");
                    break;
                case "*":
                    Console.WriteLine($"Resposta é {x*y}");
                    break;
                case "/":
                    Console.WriteLine($"Resposta é {x/y}");
                    break;
                case "pow":
                    double potencia = Math.Pow(x,y);
                    Console.WriteLine($"Resposta é {potencia}");
                    break;
                default:
                    Console.WriteLine("Escolha uma operação Válida");
                    break;
            }
        }

        public static void Seno(double angulo){
            double radiano = angulo * Math.PI / 180;
            Console.WriteLine($"Resposta é {Math.Sin(radiano)}");
        }

        public static void Cosseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            Console.WriteLine($"Resposta é {Math.Cos(radiano)}");
        }
        public static void Tangente(double angulo){
            double radiano = angulo * Math.PI / 180;
            Console.WriteLine($"Resposta é {Math.Tan(radiano)}");
        }

        public static void RaizQuadrada(double x){
            Console.WriteLine($"Raiz quadrada é {Math.Sqrt(x)}");
        }
    }
}