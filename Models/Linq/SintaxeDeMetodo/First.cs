using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.Linq.SintaxeDeMetodo
{
    public class First
    {
        public static void TestandoFirst(List<PessoaLinq> listaPessoas)
        {
            var resultado = listaPessoas.First();
            Console.WriteLine(resultado.nome);
        }

        public static void TestandoFirstOrDefault(List<PessoaLinq> listaPessoas)
        {
            var resultado = listaPessoas.FirstOrDefault(x => x.idade < 2);
            Console.WriteLine(resultado?.nome);
        }
    }
}