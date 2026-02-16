using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class Pessoa
    {
        public string? Nome { get; set;}
        public int Idade { get; set;}

        public void Apresentar()
        {
            Console.WriteLine($"Olá, Sou {Nome}, tenho {Idade} anos");
        }
    }
}