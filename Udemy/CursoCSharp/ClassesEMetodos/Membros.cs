using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "";
            sicrano.Idade = 0;


            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.AprensentarNoConsole();
            //sicrano.Zerar();
            //sicrano.AprensentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Beto";
            fulano.Idade = 21;

            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine(apresentacaoDoFulano);
        }
    }
}
