using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exercicios.Calculos
{
    class Turma
    {
        public static void MaiorMenor()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("     Maior e menor da turma    ");
            Console.WriteLine("========================================\n");
            Console.Write("Por favor, digite a quantidade de alunos(a) da classe: ");
            string entrada = Console.ReadLine();

            int.TryParse(entrada, out int alunos);

            int maiorMatricula = 0;
            double maiorAltura = 0;

            int menorMatricula = 0;
            double menorAltura = 0;


            for (int i = 1; i <= alunos; i++)
            {
                Console.Write("\nPor favor, digite a Matricula do {0}º aluno(a): ",i);
                entrada = Console.ReadLine();

                int.TryParse(entrada, out int matriculaDigitada);

                Console.Write("Por favor, digite a Altura do {0}º aluno(a): ", i);
                entrada = Console.ReadLine();

                double.TryParse(entrada, out double alturaDigitada);

                if (alturaDigitada > maiorAltura)
                {
                    maiorAltura = alturaDigitada;
                    maiorMatricula = matriculaDigitada;
                }
                if(menorAltura == 0) { menorAltura = alturaDigitada; }

                if(menorAltura > alturaDigitada)
                {
                    menorMatricula = matriculaDigitada;
                    menorAltura = alturaDigitada;
                }
                
                
            }
            Console.WriteLine("A matricula do aluno(a) mais alto(a) é {0}, e a altura dele(a) é {1}",
                maiorMatricula,
                maiorAltura.ToString("#.##")
                );
            Console.WriteLine("A matricula do aluno(a) mais baixo(a) é {0}, e a altura dele(a) é {1}",
                menorMatricula,
                menorAltura.ToString("#.##")
                );

        }
    }
}
