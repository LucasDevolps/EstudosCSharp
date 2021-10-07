using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual é o seu nome? ");

            string nome = Console.ReadLine();


            Console.Write("Qual é a sua idade? ");
            int idade = int.Parse(Console.ReadLine());


            //Usando o CultereInfo ele ignora o simbulo e
            // usa somente o ponto para separar as casa decimais

            Console.Write("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine(),
                CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R${salario}");

        }
    }
}
