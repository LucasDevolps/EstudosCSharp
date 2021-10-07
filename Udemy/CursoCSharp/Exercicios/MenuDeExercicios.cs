using System;
using System.Collections.Generic;

using CursoCSharp.Exercicios.Calculos;



namespace CursoCSharp.Exercicios
{
    class MenuDeExercicios
    {
        public static void Executar()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine(" Escolha uma opção de exercicio ");
            Console.WriteLine("================================= \n\n");
            Console.WriteLine("Escolha uma opção de exercicio: \n");

            List<string> exercicios = new List<string>();

            exercicios.Add("1 - Calculo da idade média dos alunos(a)");
            exercicios.Add("2 - Verificador de impar/par");
            exercicios.Add("3 - Pessoas maiores de 18");
            exercicios.Add("4 - Calculo de salários");
            exercicios.Add("5 - Mais alto e mais baixo da turma");

            foreach (string exercicio in exercicios)
            {
                Console.WriteLine(exercicio);
            }
            Console.Write("\n Digite o exercicio que você deseja: ");

            string entrada = Console.ReadLine();
            int.TryParse(entrada, out int opcaoMenu);

            Console.Clear();
            switch (opcaoMenu)
            {
                case 1:
                    MediaAlunos.MediaDeNotas();
                    break;
                case 2:
                    ImparOuPar.ImparPar();
                    break;
                case 3:
                    Maioridade.pessoasDeMaior();
                    break;
                case 4:
                    Salarios.CalculoReajuste();
                    break;
                case 5:
                    Turma.MaiorMenor();
                    break;

            }
        }   

    }
}
