using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.POO.AprendendoInterfaces
{
    public interface IAnimal
    {
        public string? Especie {get; set;}

        public void EmitirSom();
        public void Locomover();
        public void Alimentar();
    }
}