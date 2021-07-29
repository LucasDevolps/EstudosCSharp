using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CursoCSharp.Exercicios.Calculos
{
    public class Salarios
    {
        public static void CalculoReajuste()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("     Calculo para reajuste salárial    ");
            Console.WriteLine("========================================\n");
            Console.Write("Por favor, digite o seu salário: ");
            string entrada = Console.ReadLine();

            double.TryParse(entrada, out double salario);
            double novoSalario = salario;

            if(salario <= 300)
            {
                novoSalario += ((salario / 100) * 50);
            }
            else
            {
                novoSalario += ((salario / 100) * 30);
            }
            CultureInfo culture = new CultureInfo("pt-BR");

            Console.WriteLine("O seu salário era {0} e com o reajuste passa a ser {1}"
                ,salario.ToString("C2",culture)
                ,novoSalario.ToString("C2",culture));
        }
    }
}
