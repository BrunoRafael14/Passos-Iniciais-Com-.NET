using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.POO
{
    public class AprendendoAbstracao
    {
        public string? Nome { get; set; }
        public int Numero { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Ola, nome da classe é {Nome}, número escolhido foi {Numero}");
        }
    }
}