using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.Linq.SintaxeDeMetodo
{
    public class AprendendoQuestoesCalculo
    {
        public static void TestandoSum(List<PessoaLinq> listaPessoas)
        {
            var somaDasIdades = listaPessoas.Sum(x => x.idade);
            Console.WriteLine(somaDasIdades);
        }

        public static void TestandoAverage(List<PessoaLinq> listaPessoas)
        {
            var mediaIdades = listaPessoas.Average(x => x.idade);
            Console.WriteLine(mediaIdades);
        }

        public static void TestandoCount(List<PessoaLinq> listaPessoas)
        {
            var quantidadeElementos = listaPessoas.Count(x => x.idade > 22);
            Console.WriteLine(quantidadeElementos);
        }

        public static void TestandoRange(List<PessoaLinq> listaPessoas)
        {
            var range = Enumerable.Range(1,10);
            foreach (var i in range)
            {
                Console.WriteLine(i);
            }
        }
    }
}