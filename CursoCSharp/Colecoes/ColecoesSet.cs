using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
     

    class ColecoesSet
    {
        public static void Executar()
        {
            /*
                hashset é uma instrutura não indexada e não aceita repetição.
             */

            Produto livro = new Produto("Game of Thrones", 49.9);


            HashSet<Produto> carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            HashSet<Produto> combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8º Temporada Game of Thrones", 99.9),
                new Produto("Poster",10),
                new Produto("Poster",10),
            };
            //Adiciona um monte de elementos dentro de um array
            // carrinho.AddRange(combo);
            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);

            // carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                // Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
        }
    }
}
