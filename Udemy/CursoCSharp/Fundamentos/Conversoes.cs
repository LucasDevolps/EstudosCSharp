using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar()
        {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            //Cast, conversão explicita
            int notaTruncada = (int) nota;

            Console.WriteLine("Nota truncada: {0}", notaTruncada);

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();

            int IdadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeString);

            IdadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeString);

            /*
            Console.Write("Digite um número: ");
            string palavra = Console.ReadLine();
            //int numero;
            //int.TryParse(palavra, out int numero);
            Console.WriteLine("Resultado: {0}", numero);

            */

            Console.Write("Digite o primeiro número: ");
            int.TryParse(Console.ReadLine(), out int numero);
            Console.WriteLine("Resultado1: {0}", numero);

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado2: {0}", numero2);


        }
    }
}
