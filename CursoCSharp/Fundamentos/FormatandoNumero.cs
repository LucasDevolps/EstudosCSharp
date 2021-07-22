using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;

            //Uma casa decimal
            Console.WriteLine(valor.ToString("F1"));

            //Transformando em moeda
            Console.WriteLine(valor.ToString("C"));

            //Percentual
            Console.WriteLine(valor.ToString("P"));

            //Um numero com duas casas decimais 
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultura = new CultureInfo("pt-BR");

            //Valor de moeda sem casas decimais 
            Console.WriteLine(valor.ToString("C0",cultura));

            int inteiro = 256;

            //Numero com 10 posições 
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
