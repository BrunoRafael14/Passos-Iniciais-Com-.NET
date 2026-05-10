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

        public static void ProjetandoDados(List<PessoaLinq> listaPessoas)
        {
            var resultado = from pessoa in listaPessoas select new { NomePessoa = pessoa.nome, pessoa.idade};

            foreach (var result in resultado)
            {
                Console.WriteLine($"{result.NomePessoa} | {result.idade}");
            }
        }

        public static void ProjetandoObjetosAnonimos(List<PessoaLinq> listaPessoas)
        {
            var resultado = from pessoa in listaPessoas select new PessoaPrivadaLinq { nome = pessoa.nome, idade = pessoa.idade + 10};

            foreach (var result in resultado)
            {
                Console.WriteLine($"{result.nome} | {result.idade}");
            }
        }

        public static void Join(List<PessoaLinq> listaPessoas)
        {
            
        }

        public static void GroupBy(List<PessoaLinq> listaPessoas)
        {
            var resultado = from pessoa in listaPessoas 
                            group pessoa by pessoa.idade into agrupamentoIdade
                            select agrupamentoIdade;
            foreach (var result in resultado)
            {
                Console.WriteLine($"Idade: {result.Key}");
                foreach (var registros in result)
                {
                    Console.WriteLine($"{registros.id} | {registros.nome}");
                }
            }
        }

        public static void Join(List<PessoaLinq> listaPessoas, List<EnderecoLinq> listaEnderecos)
        {
            var resultado = from pessoa in listaPessoas
                            join endereco in listaEnderecos on pessoa.endereco_id equals endereco.id
                            select new
                            {
                                pessoa,
                                endereco
                            };
                            
            foreach (var result in resultado)
            {
                Console.WriteLine($" Id: {result.pessoa.id} \n Nome: {result.pessoa.nome} \n Endereço: {result.endereco.rua}, {result.endereco.bairro}, {result.endereco.cidade}");
            }
        }
    }
}