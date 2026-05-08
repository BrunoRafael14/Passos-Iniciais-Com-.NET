using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Passos_iniciais_com_.NET.Models.Linq
{
    public class ExecucaoLinq
    {
        public static void ExecucaoSintaxeExpressao(List<PessoaLinq> listaPessoas)
        {
            var resultado = from pessoa in listaPessoas
                // where pessoa.nome!.ToLower().Substring(0,2) == "Al".ToLower()
                // where pessoa.idade < 28
                orderby pessoa.idade descending
                select pessoa;
            foreach (var result in resultado)
            {
                Console.WriteLine($"{result.id} | {result.nome} | {result.idade} | {result.endereco_id}");
            }
        }
    }
}