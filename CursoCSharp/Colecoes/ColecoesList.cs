using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        //Construtor padrão
        public Produto()
        {

        }
    }

     

    class ColecoesList
    {
        public static void Executar()
        {
            Produto livro = new Produto("Game of Thrones", 49.9);


            List<Produto> carrinho = new List<Produto>();
            carrinho.Add(livro);

            List<Produto> combo = new List<Produto>()
            {
                new Produto("Camisa", 29.9),
                new Produto("8º Temporada Game of Thrones", 99.9),
                new Produto("Poster",10)
            };
            //Adiciona um monte de elementos dentro de um array
            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);

            carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
        }
    }
}
