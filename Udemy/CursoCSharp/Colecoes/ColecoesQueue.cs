using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Fulano");
            fila.Enqueue("Sicrano");
            fila.Enqueue("Beltrano");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (string pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            Queue salada = new Queue();

            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
