using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // Area da circunferencia

            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            
            double area = PI * raio * raio;

            Console.WriteLine("Área é: "+(area + 1000));

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo: " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            // -128 até 127
            //sbyte saldoDeGols = sbyte.MinValue;

            short salario = short.MaxValue;
            Console.WriteLine("Salario: "+salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor valor do inteiro: " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor long: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População mundial: " + populacaoMundial);

            //Quando for um valor literal, é preciso colocar o 'f' no final da atribuição 
            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do computador: " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00;
            Console.WriteLine("Valor da Apple: " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distância entre as estrelas: "+ distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra: "+letra);

            string texto = "Seja bem vindo ao Curso de C#!";
            Console.WriteLine(texto);
        }
    }
}
