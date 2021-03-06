using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.Exercicios;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main() {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentarios - Fundamentos", Comentarios.Executar},
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados  - Fundamentos", LendoDados.Executar},
                {"Formatando numeros  - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar},

                //Estruturas de Controle 
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                
                //Repetições
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrutura Do While - Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},

                {"Exercicios de fixação", MenuDeExercicios.Executar},

                //Classes e Métodos 
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Construtores - Classes e Métodos", Construtores.Executar},  
                {"Metodos Com Retorno - Classes e Métodos", MetodosComRetorno.Executar},

                {"Exercicios de Orientação a Obejetos", Objetos.Executar},
                {"Métodos Estáticos - Classes e Métodos", MetodosEstaticos.Executar },
                {"Atributos Estáticos - Classes e Métodos", AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar},
                {"Params - Classes e Métodos",Params.Executar },
                {"Parametros Nomeados - Classes e Métodos", ParametrosNomeados.Executar },
                {"Get Set - Classes e Métodos",  GetSet.Executar},
                {"Props - Classes e Métodos", Props.Executar },
                {"Readonlu - Classes e Métodos", ReadOnly.Executar },
                {"Enum - Classes e Métodos", ExemploEnum.Executar },
                {"Struct - Classes e Métodos", ExemploStruct.Executar },
                {"Struct vs Classe - Classes e Métodos", StructVsClasse.Executar },
                {"Valor vs Referencia - Classes e Métodos", ValorVsReferencia.Executar },
                {"Parâmetros por Referência - Classes e Métodos", ParametrosPorReferencia.Executar },
                {"Parâmetros com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar },

                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar },
                {"List - Coleções", ColecoesList.Executar },
                {"Coleções Array List - Coleções", ColecoesArrayList.Executar },
                {"Set - Coleções",ColecoesSet.Executar },
                {"Queeu - Coleções", ColecoesQueue.Executar },
                {"Igualdade - Coleções", Igualdade.Executar },
                {"Stack - Coleções", ColecoesStack.Executar },
                {"Dictionary - Coleções", ColecoesDictiofnary.Executar },

                //OO
                {"Dictionary - Orientação a Objetos", Heranca.Executar },
                {"Construtor This - Orientação a Objetos", ConstrutorThis.Executar },
                {"Encapsulamento - Orientação a Objetos", OO.Encapsulamento.Executar },
                {"Polimorfismo - Orientação a Objetos", OO.Polimorfismo.Executar },
                {"Abstract - Orientação a Objetos", OO.Abstract.Executar },
                {"Interface - Orientação a Objetos", OO.Interface.Executar },
                {"Sealed - Orientação a Objetos", OO.Sealed.Executar },

                //Métodos e Funcões 
                {"Exemplo Lambda - Metodos e Funções", ExemploLambda.Executar },
                {"Usando Delegates - Metodos e Funções", UsandoDelegates.Executar },
                {"Delegates como Função Anonima - Métodos & Funções", DelegateFunAnonima.Executar },
                {"Delegates como Parâmetros - Métodos & Funções", DelegatesComoParametros.Executar },
                {"Métodos de Extensão - Métodos & Funções", MetodosDeExtensao.Executar },
                
                //Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar },
                {"Exceções personalizadas - Exceções", ExcecoesPersonalizadas.Executar },

                //Api
                {"Primeiro Arquivo - Usando Api", PrimeiroArquivo.Executar },
                {"Lendo Arquivos - Usando Api", LendoArquivos.Executar },
                {"Exemplos de FileInfo - Usando Api", ExemploFileInfo.Executar },
                {"Diretórios - Usando Api", Diretorios.Executar },

                {"Exemplo Path - Usando Api", ExemploPath.Executar },
                {"Exemplo DirectoryInfo - Usando Api", ExemploDirectoryInfo.Executar },
                {"Exemplo DateTime - Usando Api", ExemploDateTime.Executar },
                {"Exemplo Timespan - Usando Api", ExemploTimeSpan.Executar },

                //Tópicos avançados
                {"LINQ #01 - Tópicos Avançados", LINQ1.Executar },
                {"LINQ #02 - Tópicos Avançados", LINQ2.Executar },
                {"Nullables - Tópicos Avançados", Nullables.Executar },
                {"Dynamics - Tópicos Avançados", Dynamics.Executar },
                {"Genéricos - Tópicos Avançados", Genericos.Executar },

            });

            central.SelecionarEExecutar();
        }
    }
}