using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Exercícios.CadastroDeAlunos
{
    public class Aluno
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public void PuxarDadosAluno()
        {
            Console.WriteLine($"Nome: {Nome} \nIdade: {Idade}");
        }
    }
}