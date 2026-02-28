using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Exercícios.CadastroDeAlunos
{
    public class Turma
    {
        public string? Nome { get; set;}
        public List<Aluno> Alunos = new List<Aluno>();

        public void AdicionarAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
            aluno.TurmaAluno = Nome;
            Console.WriteLine($"{aluno.Nome} foi adicionado(a) a Turma de {Nome}");
        }

        public void RemoverAluno(Aluno aluno)
        {
            Alunos.Remove(aluno);
            Console.WriteLine("Aluno Removido");
        }

        public void PuxarInformacoesTurma()
        {
            Console.Write("Alunos: ");
            foreach(var aluno in Alunos)
            {
                Console.Write($"{aluno.Nome}, ");
            }
        }
    }
}