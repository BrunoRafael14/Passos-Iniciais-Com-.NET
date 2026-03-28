using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.POO.AprendendoInterfaces
{
    public class Gato : IAnimal
    {
        public string? Especie { get; set; }

        public void EmitirSom()
        {
            Console.WriteLine("Miau");
        }
        public void Locomover()
        {
            Console.WriteLine("Caminhar");
        }
        public void Alimentar()
        {
            Console.WriteLine("Comer");
        }
    }
}