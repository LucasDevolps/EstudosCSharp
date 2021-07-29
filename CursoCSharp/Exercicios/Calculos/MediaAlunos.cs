using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exercicios.Calculos
{
    public class MediaAlunos
    {
        public static void MediaDeNotas()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("     Calculo de média dos alunos(a)   ");
            Console.WriteLine("========================================\n");
            Console.Write("Por favor, digite quantos alunos tem na sala: ");
            string entrada = Console.ReadLine();

            int.TryParse(entrada, out int alunos);

            double notas = 0;
            double media = 0;
            for (int i = 1; i <= alunos; i++)
            {
                Console.Write("Digite a nota do {0}º aluno: ", i);
                entrada = Console.ReadLine();

                double.TryParse(entrada, out double notasDigitadas);
                notas += notasDigitadas;
            }
            if(notas > 0)
            {
                media = (notas / alunos);
            }
            Console.WriteLine("A média de notas desta classe é {0}", media.ToString("#.##"));
            
        }
    }
}
