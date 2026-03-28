using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.POO.AprendendoInterfaces
{
    public class AguaViva : IAnimal
    {
        public string? Especie { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("...");
        }
        public void Locomover()
        {
            Console.WriteLine("Nadar");
        }
        public void Alimentar()
        {
            Console.WriteLine("Comer");
        }
    }
}