using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.Linq.SintaxeDeMetodo
{
    public class AprendendoSingle
    {
        public static void AprendizadoSingle(List<PessoaLinq> listaPessoas)
        {
            try
            {
                var resultado = listaPessoas.Single(x => x.idade == 21);
                Console.WriteLine(resultado);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Funcionou"); // Nenhum ou mais de um encontrado
            }
        }   
    }
}