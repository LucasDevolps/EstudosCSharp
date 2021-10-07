using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes
{
    class ColecoesDictiofnary
    {
        public static void Executar()
        {
            Dictionary<int, string> filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2004, "Os Incríveis");
            filmes.Add(2006, "O Grande Truque");

            if (filmes.ContainsKey(2004))
            {
                //Buscando o valor associado a chave
                //Lança uma exception caso não encontre valor nulos 
                Console.WriteLine("2004: " + filmes[2004]);
                
                //Caso não encontre, o mesmo ir retornar vazio
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2008));

                Console.WriteLine(filmes.ContainsValue("Amnésia"));

                Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

                filmes.TryGetValue(2006, out string filme2006);

                Console.WriteLine($"Filme: {filme2006}!");

                //Percorendo somente a chave
                foreach(var chave in filmes.Keys){
                    Console.WriteLine(chave);
                }

                //Percorrendo somente o valor 
                foreach(var valor in filmes.Values)
                {
                    Console.WriteLine(valor);
                }


                //Maneira mais dificil 
                foreach(KeyValuePair<int, string> filme in filmes)
                {
                    Console.WriteLine($"{filme.Value} é de {filme.Key}");
                }

                //Maneira mais facil 
                foreach(var filme in filmes)
                {
                    Console.WriteLine($"{filme.Value} é de {filme.Key}");
                }
            }
        }
    }
}
