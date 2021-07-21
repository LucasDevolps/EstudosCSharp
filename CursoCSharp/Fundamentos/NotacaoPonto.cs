using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar() {
            var saudacao = "olá " 
                .ToUpper()
                .Insert(3, " World!")
                .Replace("World!", "Mundo!");

            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            string valorImportante = null;
            /*
             *  Caso a váriavel esteja vazia ultilizar o 
             *  "?" para não dar erro.
             */

            Console.WriteLine(valorImportante?.Length);
        }
    }
}
