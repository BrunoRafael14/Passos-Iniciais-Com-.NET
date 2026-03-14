using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.POO.ClassesAbstratas
{
    public abstract class Jogador
    {
        protected string? Nome {get;set;}
        protected int Idade {get;set;}
        protected string? Esporte {get;set;}

        public abstract void DefinirEsporte();

        public void MostrarDadosAtleta()
        {
            Console.WriteLine($"Dados do Atleta: \n Nome: {Nome}\n Idade: {Idade} \n Esporte: {Esporte}");
        }
    }
}