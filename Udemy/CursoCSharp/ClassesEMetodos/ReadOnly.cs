using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Cliente
    {
        public string Nome;

        readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataNascimento()
        {
            return String.Format("{0:D2}/{1:D2}/{2:D4}",Nascimento.Day,Nascimento.Month,Nascimento.Year);
        }
    }
    class ReadOnly
    {
        public static void Executar()
        {
            Cliente novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataNascimento());
        }
    }
}
