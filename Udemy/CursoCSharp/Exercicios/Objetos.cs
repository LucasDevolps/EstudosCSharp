using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Exercicios
{
    /*
        Objetos em C# – 1 Parte
        Exercício Maior Idade
        Implemente um programa no qual o usuário deverá 
        informar o nome e a idade de três pessoas. 
        O programa deverá informar o nome da pessoa que 
        possuir a maior idade. 
    */
    class Pessoa
    {
        public string Nome;
        public int Idade;
        
        public Pessoa(string nome,int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }
    }
    public class Objetos
    {
        public static void Executar()
        {
            Console.Clear();
            List<Pessoa> pessoas = new List<Pessoa>();
            
            Console.WriteLine("======================================");
            Console.WriteLine("  Informe o nome e idade das pessoas  ");
            Console.WriteLine("======================================\n");
            Console.Write("Informe a quantidade de pessoas: ");
            
            string entrada = "";
            
            if(Console.ReadLine().Length > 0)
            {
                entrada = Console.ReadLine();
            }
            
            
            int.TryParse(entrada, out int qtdPessoas);
            if (qtdPessoas == 0) qtdPessoas = 1;

            for (int i = 1; i <= qtdPessoas; i++)
            {
                Console.Write("\nInforme o nome da {0}º pessoa: ",i);
                string nome = Console.ReadLine();

                Console.Write("Informe a idade da {0}º pessoa: ", i);
                int.TryParse(Console.ReadLine(), out int idadeDigitada);

                Pessoa pessoa = new Pessoa(nome, idadeDigitada);
                pessoas.Add(pessoa);
            }
            Console.WriteLine("\n De todas as pessoas digitas a cima, somente: ");
            foreach (Pessoa pessoa in pessoas)
            {
                if(pessoa.Idade >= 18)
                {
                    Console.WriteLine($" {pessoa.Nome}, idade {pessoa.Idade}");
                }
            }
            Console.WriteLine("\n São de maior");

        }
    }
}
