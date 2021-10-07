using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            //Action não tem retorno
            Action<string> algoNoConsole = (a) =>
            {
                Console.WriteLine("Lambda com C#!" + a);
            };

            algoNoConsole("!!!");

            //Action algoNoConsole = () =>
            //{
            //    Console.WriteLine("Lambda com C#!");
            //}; tbm posso passar action sem parametros

            //algoNoConsole();

            Func<int> JogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(JogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => 
            String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);

            Console.WriteLine(formatarData(1,1,2019));

        }
    }
}
