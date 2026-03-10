using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.POO.HerançaAndPolimorfismo
{
    public class Pessoa
    {
        public string? Nome {get;set;}
        public int idade {get;set;}
        public int matricula {get;set;}
        public virtual void Apresentar()
        {
            Console.WriteLine($"Prazer, meu nome é {Nome}, tenho {idade} anos");
        }
    }
}