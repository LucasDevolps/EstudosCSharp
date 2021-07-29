using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exercicios.Calculos
{
    public class Maioridade
    {
        public static void pessoasDeMaior()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("     Verificador de idade    ");
            Console.WriteLine("========================================\n");
            Console.Write("Por favor, digite a quantidade de pessoas: ");
            string entrada = Console.ReadLine();

            int.TryParse(entrada, out int pessoas);
            int maioridade = 0;
            for (int i = 1; i <= pessoas; i++)
            {
                Console.Write("Digite a idade da {0}º pessoa: ",i);
                entrada = Console.ReadLine();

                int.TryParse(entrada, out int idade);

                if (idade >= 18) maioridade++;
            }
            Console.WriteLine("\n No total tem {0}, pessoas de maior!",maioridade);
        }
    }
}
