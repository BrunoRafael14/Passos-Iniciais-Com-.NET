using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.Linq.SintaxeDeMetodo.SelectMany
{
    public class AprendendoSelectMany
    {

        public static void TesteSelectMany(List<ListaSelectMany> Lista2Teste)
        {
            var textosDosTextos = Lista2Teste.SelectMany(x => x.textos!);
            foreach (var i in textosDosTextos)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}