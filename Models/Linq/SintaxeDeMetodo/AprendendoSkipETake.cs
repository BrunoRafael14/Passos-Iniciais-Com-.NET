using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.Linq.SintaxeDeMetodo
{
    public class AprendendoSkipETake
    {
        public static void TestandoSkipETake(List<PessoaLinq> listaPessoas)
        {
            var tresPrimeiros = listaPessoas.Take(3);
            var ignorarTresPrimeiros = listaPessoas.Skip(3);

            foreach (var i in tresPrimeiros)
            {
                Console.WriteLine(i.nome);
            }
            Console.WriteLine("".PadLeft(20, '='));

            foreach (var i in ignorarTresPrimeiros)
            {
                Console.WriteLine(i.nome);
            }
        }
    }
}