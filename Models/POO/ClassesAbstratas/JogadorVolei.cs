using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.POO.ClassesAbstratas
{
    public class JogadorVolei : Jogador
    {
        public override void DefinirEsporte()
        {
            Esporte = "Vôlei";
        }

        public void CadastrarInformacoes()
        {
            Console.Write("Informe seu nome: ");
            Nome = Console.ReadLine();
            Console.Write("Informe sua idade: ");
            Idade = Convert.ToInt32(Console.ReadLine());
            DefinirEsporte();
        }
    }
}