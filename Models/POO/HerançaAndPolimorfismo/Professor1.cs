using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.POO.HerançaAndPolimorfismo
{
    public class Professor1 : Pessoa
    {
        public decimal Salario {get;set;}

        public override void Apresentar()
        {
            Console.WriteLine($"Sou professor {Nome}");
        }
    }
}