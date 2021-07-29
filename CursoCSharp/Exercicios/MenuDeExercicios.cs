using System;
using System.Collections.Generic;
using System.Text;
using CursoCSharp.Exercicios.Calculos;

namespace CursoCSharp.Exercicios
{
    class MenuDeExercicios
    {
        public static CalculoAlunos Executar()
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

            foreach (string exercicio in exercicios)
            {
                Console.WriteLine(exercicio);
            }
            Console.Write("\n Digite o exercicio que você deseja: ");

            string entrada = Console.ReadLine();
            int.TryParse(entrada, out int opcaoMenu);

            switch (opcaoMenu)
            {
                case 1:
                    Console.Clear();
                    break;
            }
        }   

    }
}
