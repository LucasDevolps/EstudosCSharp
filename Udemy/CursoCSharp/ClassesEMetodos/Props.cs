using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto = 0.1;

        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                //dentro do "set" o valor passo é ultilizado por essa palavra reservada "value"
                nome = value;
            }
        }
        public double Preco { get; set; }

        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco);

        }
        public CarroOpcional()
        {

        }
        public CarroOpcional(string nome, double preco)
        {
            this.nome = nome;
            Preco = preco;
        }

    }
    class Props
    {
        public static void Executar()
        {
            CarroOpcional op1 = new CarroOpcional("Ar condicionado", 3499.9);
            Console.WriteLine(op1.PrecoComDesconto);

            CarroOpcional op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);
            Console.WriteLine(op1.PrecoComDesconto);
        }

        
    }
}
