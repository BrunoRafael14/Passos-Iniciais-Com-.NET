using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class AprendendoConstrutores
    {
        // Criando construtores
        public AprendendoConstrutores()
        {
            
        }
        public AprendendoConstrutores(string nome, int numero)
        {
            Nome = nome;
            Numero = numero;
        }

        public string? Nome { get; set; }
        public int Numero {get; set;}

        public void ApresentarInformacoes()
        {
            Console.WriteLine($"{Nome} e {Numero}");
        }
    }
}