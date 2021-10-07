using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno> {
                new Aluno() {Nome = "Pedro",  Idade = 24, Nota = 8.0},
                new Aluno() {Nome = "Andre",  Idade = 21, Nota = 4.3},
                new Aluno() {Nome = "Ana",    Idade = 25, Nota = 9.5},
                new Aluno() {Nome = "Jorge",  Idade = 20, Nota = 8.5},
                new Aluno() {Nome = "Ana",    Idade = 21, Nota = 7.7},
                new Aluno() {Nome = "Julia",  Idade = 22, Nota = 7.5},
                new Aluno() {Nome = "Marcio", Idade = 18, Nota = 6.8}
            };

            try
            {
                var pedro = alunos.Single(aluno => aluno.Nome.Equals("Pedro"));
                Console.WriteLine($"{pedro.Nome}: {pedro.Nota}");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Oops! Erro: "+ ex.Message);
            }

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome.Equals("Fulano"));

            /*
             * Só ultilizar o metodo sigle ele retorna um erro, caso não encontre
             * 
             * Ultilizando o SingleOrDefault de qualquer forma ele irá iniciar a variável
             * 
             */

            if (fulano == null)
            {
                Console.WriteLine("Aluno inexistente!");
            }

            try
            {
                var ana = alunos.First(aluno => aluno.Nome.Equals("Ana"));
                Console.WriteLine(ana.Nota);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ooops! Erro: "+ex.Message);
            }

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nome.Equals("Sicrano"));

            if(sicrano == null)
            {
                Console.WriteLine("Aluno Inexistente!");
            }


            var outroAluno = alunos.LastOrDefault(aluno => aluno.Nome.Equals("Ana"));
            Console.WriteLine(outroAluno.Nota);

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var item in exemploSkip) {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(alunos => alunos.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(alunos => alunos.Nota);
            Console.WriteLine(menorNota);

            var somatorionotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorionotas);

            var mediaDaTurma = alunos.Average(alunos => alunos.Nota);
            Console.WriteLine(mediaDaTurma.ToString("#.##"));

            var MediaDosAlunosAprovados = alunos
                .Where(alunos => alunos.Nota >= 7)
                .Average(alunos => alunos.Nota);
            Console.WriteLine(MediaDosAlunosAprovados);
        }
    }
}
