using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class AprendendoPropriedadesEMetodos
    {
        // Criando uma propriedade de teste
        public string? NomePropriedade { get; set;}
        // Fazendo validação do get e set
        private int _numeroPropriedade;
        public int NumeroPropriedade 
        { 
            get 
            {
                return _numeroPropriedade;
            } 

            set
            {
                if (value != 14)
                {
                    throw new ArgumentException("Número errado");  
                } 
                _numeroPropriedade = value;
            }
        }


        public void ApresentarPropriedades()
        {
            Console.WriteLine($"{NomePropriedade} e {NumeroPropriedade}");
        }
    }
}