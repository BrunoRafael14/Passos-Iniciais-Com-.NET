using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models
{
    public class AprendendoParametros
    {
        public static void ParametrosNomeadosEReferencial(string nome, ref int idade)
        {
            int idadeDobrada = idade * 2;
            string nomeAtualizado = nome.Insert(0, "Gay - ");

            Console.WriteLine($"""
            Nome: {nomeAtualizado}
            Idade em Dobro: {idadeDobrada}
            """);
        }
    }
}