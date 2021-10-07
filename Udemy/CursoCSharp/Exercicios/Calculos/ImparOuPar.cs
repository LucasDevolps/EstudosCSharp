using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exercicios.Calculos
{
    public class ImparOuPar
    {
        public static void ImparPar()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("     Verificador e impar ou par   ");
            Console.WriteLine("========================================\n");
            Console.Write("Por favor, digite um número: ");
            string entrada = Console.ReadLine();

            int.TryParse(entrada, out int numero);

            if(numero % 2 == 0)
            {
                Console.WriteLine("\n Este número é PAR");
            }
            else
            {
                Console.WriteLine("\n Este número é IMPAR");
            }
        }
    }
}
