using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.Linq.SintaxeDeMetodo
{
    public class AprendendoSintaxeDeMetodo
    {

        public static void TestandoSelect(List<PessoaLinq> listaPessoas)
        {
            var response = listaPessoas.Select( x => x.idade);
            foreach (var i in response)
            {
                Console.WriteLine(i);
            }
        }

        public static void TestandoWhere(List<PessoaLinq> listaPessoas)
        {
            var resultado = listaPessoas.Where( x => (x.idade + 10) > 32);

            foreach (var i in resultado)
            {
                Console.WriteLine(i.nome);
            }
        }    

        public static void TestandoOrderBy(List<PessoaLinq> listaPessoas)
        {
            var resultado = listaPessoas.OrderBy( x => x.nome);
            foreach (var i in resultado)
            {
                Console.WriteLine(i.nome);
            }
        }    

        public static void TestandoReverse(List<PessoaLinq> listaPessoas)
        {
            listaPessoas.Reverse();
            foreach (var i in listaPessoas)
            {
                Console.WriteLine(i.nome);
            }
        }
    }
}