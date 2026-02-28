using Passos_iniciais_com_.NET.Models;
using Passos_iniciais_com_.NET.Exercícios;
using Passos_iniciais_com_.NET.Exercícios.CadastroDeAlunos;


// Console.WriteLine("Hello, Bruno!");

// Criando um comentário C#


/*
instanciando uma Classe

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Alexiano";
pessoa1.Idade = 21;
pessoa1.Apresentar();
*/

// TiposDados.MostrarDados();

// Conversão de Tipos
// string a = "15-";
// int.TryParse(a, out int b);
// Console.WriteLine(b);

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

// -- Matrizes --
//AprendendoMatrizes.CriandoMatrizBidimensional();

// Propriedades, Métodos e Construtores
// AprendendoPropriedadesEMetodos teste01 = new AprendendoPropriedadesEMetodos();
// teste01.NomePropriedade = "Xablauscledio";
// teste01.SobrenomePropriedade = "Da Silva";
// teste01.NumeroPropriedade = 14;
// teste01.ApresentarPropriedades();

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
Aluno aluno1 = new Aluno();
aluno1.Nome = "Alvin";
aluno1.Idade = 15;
aluno1.PuxarDadosAluno();

Aluno aluno2 = new Aluno();
aluno2.Nome = "Jordan";
aluno2.Idade = 18;
aluno2.PuxarDadosAluno();

Turma turma1 = new Turma();
turma1.Nome = "Filosofia";

turma1.AdicionarAluno(aluno1);
turma1.AdicionarAluno(aluno2);
turma1.PuxarInformacoesTurma();

aluno1.PuxarDadosAluno();