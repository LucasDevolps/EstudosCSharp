using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1,16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            while(tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.Write("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    //pulando linha sem aplicar a alteração do console
                    Console.WriteLine();

                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write("Numero encontrado em {0} tentativas", tentativas);

                    Console.BackgroundColor = corAnterior;

                    Console.WriteLine();
                }
                else if(palpite > numeroSecreto)
                {
                    Console.WriteLine("\n Menor... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0} \n\n",tentativasRestantes);
                }
                else
                {
                    Console.WriteLine("\n Maior... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0} \n\n", tentativasRestantes);
                }
            }

        }
    }
}
