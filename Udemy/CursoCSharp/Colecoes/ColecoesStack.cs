using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach(var item in pilha)
            {
                Console.Write($"{item} ");
            }

            //Saca o ultimo elemento adicionado na lista 
            Console.WriteLine($"\n Pop: {pilha.Pop()}");
            
            //Exibindo a pilha novamente
            foreach (var item in pilha)
            {
                Console.Write($"{item} ");
            }

            //Pegando o próximo elemento da pilha
            Console.WriteLine($"\n Peek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);
        }
    }
}
