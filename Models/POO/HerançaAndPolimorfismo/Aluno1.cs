using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.POO.HerançaAndPolimorfismo
{
    public class Aluno1 : Pessoa
    {
        public double Nota {get;set;}

        public override void Apresentar()
        {
            Console.WriteLine($"Sou aluno {Nome}");
        }
    }
}