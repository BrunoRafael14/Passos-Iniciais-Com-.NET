using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.POO
{
    public class AprendendoEncapsulamento
    {
        public AprendendoEncapsulamento(string nome, int idade, string cpf)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.cpf = cpf;
        }

        public string? Nome {get; set;}
        public int Idade {get;set;}
        private string cpf;

        public string GetCpf()
        {
            return cpf;
        }
    }
}