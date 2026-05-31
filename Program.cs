using Passos_iniciais_com_.NET.Models;
using Passos_iniciais_com_.NET.Exercícios;
using Passos_iniciais_com_.NET.Exercícios.CadastroDeAlunos;
using Passos_iniciais_com_.NET.Models.POO;
using Passos_iniciais_com_.NET.Models.POO.HerançaAndPolimorfismo;
using Passos_iniciais_com_.NET.Models.POO.ClassesAbstratas;
using Passos_iniciais_com_.NET.Models.POO.AprendendoInterfaces;
using Passos_iniciais_com_.NET.Models.SerializacaoComJSON;
using Passos_iniciais_com_.NET.Models.AsyncEAwait;
using Passos_iniciais_com_.NET.Models.Linq;
using Passos_iniciais_com_.NET.Models.Linq.SintaxeDeMetodo;
using Passos_iniciais_com_.NET.Models.Linq.SintaxeDeMetodo.SelectMany;
using System.Linq;


// Console.WriteLine("Hello, Bruno!");

// Criando um comentário C#


/*
instanciando uma Classe

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Alexiano";
pessoa1.Idade = 21;
pessoa1.Apresentar();
*/

// Tipos de dados

// TiposDados.MostrarDados();

// Conversão de Tipos
// string a = "15-";
// int.TryParse(a, out int b);
// Console.WriteLine(b);

// TiposDados.ConversaoExplicita();

// Dados por referência
// TiposPorReferencia.TestandoTiposPorReferencia();
// ExpressoesLambda.TestandoExpressoesLambda();

//Operadores Condicionais
//OperadoresCondicionais.Condicionais01(5);
// OperadoresCondicionais.SwitchCase(100);

//Operadores Lógicos
// OperadoresLogicos.Or(17, true);
// OperadoresLogicos.And(1, true);
// OperadoresLogicos.Not(true);

// Estruturas de Repetição
// EstruturasRepeticao.For(4);
// EstruturasRepeticao.While();
// EstruturasRepeticao.DoWhile();

// Estrutura de Dados
// -- Arrays --
// AprendendoArrays.Arrays.Array();
// AprendendoArrays.Arrays.PercorrendoArray();
// AprendendoArrays.AuterandoQuantidadeArray();
// AprendendoArrays.CopiandoArray();

// -- Listas --
//AprendendoListas.FazendoUmaLista();

// -- HashSets -- 
// AprendendoHashSet.VerificandoHashSet();
// AprendendoHashSet.AdicionandoNúmeros(200);
// Console.WriteLine("------------------------------");
// AprendendoHashSet.VerificandoHashSet();

// -- Matrizes --
//AprendendoMatrizes.CriandoMatrizBidimensional();

// Propriedades, Métodos e Construtores
// ----- Propriedades e Metodos -----
// AprendendoPropriedadesEMetodos teste01 = new AprendendoPropriedadesEMetodos();
// teste01.NomePropriedade = "Xablauscledio";
// teste01.SobrenomePropriedade = "Da Silva";
// teste01.NumeroPropriedade = 14;
// teste01.ApresentarPropriedades();
// ----- Construtores -----
// AprendendoConstrutores ap1 = new AprendendoConstrutores("Bruno", 14);
// ap1.ApresentarInformacoes();

// Manipulação de Strings
// ----- Concatenação -----
// ManipulacaoStrings.Concatenacao();
// ManipulacaoStrings.Interpolacao();
// Formatacoes.ValoresMonetarios();
// ManipulacaoStrings.StringBuilderTeste();

// Leitura de Arquivos
// LeituraDeArquivos.LendoArquivo();
// LeituraDeArquivos.VendoThrow2();
// try
// {
//     LeituraDeArquivos.TestandoExceptionsPersonalizadas();
// }
// catch
// {
//     Console.WriteLine("sei la");
// }





// Queue e Stack
// AprendoFilasEPilhas.Filas();
// AprendoFilasEPilhas.Pilhas();

// Dicionarios
// AprendendoDicionarios.Dicionarios();

// Serialização
// AprendendoSerializacao.Serializar("C:/Users/Bruno Rafael/Desktop/Estudar/C#/Passos iniciais com .NET/Models/SerializacaoComJSON/teste.json");

// ----- Poo -----
// Abstração
/*
AprendendoAbstracao P1 = new AprendendoAbstracao();
P1.Nome = "Alexiano";
P1.Numero = 14;
P1.Apresentar();
*/

// Encapsulamento
/*
AprendendoEncapsulamento p1 = new AprendendoEncapsulamento("Bruno", 20, "138.258.424-52");
Console.WriteLine($" Nome: {p1.Nome} /n Idade: {p1.Idade} /n CPF: {p1.GetCpf()}");
*/

// Herança
/*
Aluno1 al1 = new Aluno1();
al1.Nome = "Bruno";
al1.idade = 20;
al1.matricula = 17;
al1.Nota = 10;

Professor1 pr1 = new Professor1();
pr1.Nome = "Alexiano";
pr1.idade = 42;
pr1.matricula = 19;
pr1.Salario = 1700;

al1.Apresentar();
pr1.Apresentar();
*/

// Classes Abstratas
/*
JogadorBasquete jogador1 = new JogadorBasquete();
jogador1.CadastrarInformacoes();
jogador1.MostrarDadosAtleta();

JogadorVolei jogador2 = new JogadorVolei();
jogador2.CadastrarInformacoes();
jogador2.MostrarDadosAtleta();
*/

// Interfaces
/*
Gato animal1 = new Gato();
AguaViva animal2 = new AguaViva();
EsponjaDoMar animal3 = new EsponjaDoMar();

animal1.Especie = "Felis catus";
animal2.Especie = "Aurelia aurita";
animal3.Especie = "Euspongia officinalis";

Console.WriteLine($"{animal1.Especie}");
animal1.EmitirSom();
animal1.Alimentar();
animal1.Locomover();
Console.WriteLine($"{animal2.Especie}");
animal2.EmitirSom();
animal2.Alimentar();
animal2.Locomover();
Console.WriteLine($"{animal3.Especie}");
animal3.EmitirSom();
animal3.Alimentar();
animal3.Locomover();
*/

// Programação Assíncrona
// AprendendoProgramacaoAssincrona.TestandoAsync();
// AprendendoProgramacaoAssincrona.TestandoSemAsync();
// Console.ReadKey(); // Método apenas para aguardar 

// Linq

var listaPessoas = new List<PessoaLinq>()
{
    new PessoaLinq{id = 1, nome = "Alexiano", idade= 21, endereco_id = 1},
    new PessoaLinq{id = 2, nome = "Athinos", idade= 31, endereco_id = 1},
    new PessoaLinq{id = 3, nome = "Expartan", idade= 28, endereco_id = 2},
    new PessoaLinq{id = 4, nome = "Toystiles", idade= 28, endereco_id = 2},
    new PessoaLinq{id = 5, nome = "Xaun Mendes", idade= 21, endereco_id = 2}
};
var listaEnderecos = new List<EnderecoLinq>()
{
    new EnderecoLinq{id = 1, rua = "Santa Maria Gorete, 94", bairro = "Petrópolis", cidade = "Caruaru"},
    new EnderecoLinq{id = 2, rua = "Santa Maria Gorete, 81", bairro = "Petrópolis", cidade = "Caruaru"},
};

// Sintaxe Expressão de Consulta
// ExecucaoLinq.ExecucaoSintaxeExpressao(listaPessoas);

// Projecao De Dados
// ExecucaoLinq.ProjetandoObjetosAnonimos(listaPessoas);

// Group By
// ExecucaoLinq.GroupBy(listaPessoas);

// Join
// ExecucaoLinq.Join(listaPessoas, listaEnderecos);


// Sintaxe De Metodo
// First
// First.TestandoFirst(listaPessoas);
// First.TestandoFirstOrDefault(listaPessoas);
// AprendendoSingle.AprendizadoSingle(listaPessoas);
// AprendendoSintaxeDeMetodo.TestandoWhere(listaPessoas);
// AprendendoSintaxeDeMetodo.TestandoOrderBy(listaPessoas);
// AprendendoSintaxeDeMetodo.TestandoReverse(listaPessoas);
// AprendendoSintaxeDeMetodo.TestandoSelect(listaPessoas);
// AprendendoSkipETake.TestandoSkipETake(listaPessoas);
// AprendendoMetodosDeContas.TestandoSum(listaPessoas);
// AprendendoMetodosDeContas.TestandoAverage(listaPessoas);
// AprendendoMetodosDeContas.TestandoCount(listaPessoas);

 var Lista2Teste = new List<ListaSelectMany>
        {
            new ListaSelectMany {nome = "A", textos = new List<string> {"AAAAAAAAAA", "aaaaaaaaaaaa"}}, 
            new ListaSelectMany {nome = "B", textos = new List<string> {"BBBBBBBBBB", "bbbbbbbbbbbb"}},
            new ListaSelectMany {nome = "C", textos = new List<string> {"CCCCCCCCCC", "cccccccccccc"}}
        };

// AprendendoSelectMany.TesteSelectMany(Lista2Teste);

// Aprendendo Parâmetros
// int idadeKek = 21;
// AprendendoParametros.ParametrosNomeadosEReferencial(nome: "Alexiano", idade: ref idadeKek);

// Aprendendo Controle de loops
// AprendendoControledeLoop.TestandoContinue();
// AprendendoControledeLoop.TestandoBreak();


// EXERCÍCIOS

// Exercicio Calculadora
// Calculadora.Calcular(10, 12, "pow");
// Calculadora.Seno(45);
// Calculadora.Cosseno(45);
// Calculadora.Tangente(45);
// Calculadora.RaizQuadrada(9.3);

// Exercicio Menu Interativo com loops
// MenuInterativo.Menu();

// Exercicio com Arrays
// ExerciciosArrays.ArmazemDeInfomacoes();

// Exercícios com métodos e propriedades
// ----- Cadastro De Alunos -----
// Aluno aluno1 = new Aluno();
// aluno1.Nome = "Alvin";
// aluno1.Idade = 15;
// aluno1.PuxarDadosAluno();

// Aluno aluno2 = new Aluno();
// aluno2.Nome = "Jordan";
// aluno2.Idade = 18;
// aluno2.PuxarDadosAluno();

// Turma turma1 = new Turma();
// turma1.Nome = "Filosofia";

// turma1.AdicionarAluno(aluno1);
// turma1.AdicionarAluno(aluno2);
// turma1.PuxarInformacoesTurma();

// aluno1.PuxarDadosAluno();

