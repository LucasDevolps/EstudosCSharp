using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {   
            if(Nome.Length == 0){
                Console.Write("Por favor, digite um nome: ");
                Nome = Console.ReadLine();
            }
            if(Idade == 0)
            {
                Console.Write("Por favor, digite sua idade: ");
                int.TryParse(Console.ReadLine(), out Idade);
            }
            return string.Format($"Olá! me chamo {Nome} e tenho {Idade} anos.");
            
        }
        public void AprensentarNoConsole()
        {
           Console.WriteLine(Apresentar());
        }
        public void Zerar()
        {
            Nome = "";
            Idade = 0;
        }   
    }
}
