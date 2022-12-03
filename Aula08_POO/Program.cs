using Aula08_POO.Auto;
using System;

namespace Aula08_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício 01");
            Console.WriteLine();
            Exercicio_01();
            
            Console.WriteLine();

            Console.WriteLine("Exercício 02");
            Console.WriteLine();
            Exercicio_02();
        }

        private static void Exercicio_01()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "João";
            pessoa.DataNascimento = new DateTime(2000, 01, 01);
            pessoa.Altura = 1.80f;

            pessoa.ImprimirDados();

            int idade = pessoa.CalcularIdade();

            Console.WriteLine("Idade: " + idade);

            Console.ReadKey();
        }

        private static void Exercicio_02()
        {
            Carro carro = new Carro(2005, 200000);
            
            Console.WriteLine(carro.ToString());
            carro.Iniciar();
            carro.Acelerar();

            Console.WriteLine();

            Camiao camiao = new Camiao(2003, 4560000);
            
            Console.WriteLine(camiao.ToString());
            camiao.Iniciar();
            camiao.Acelerar();

            Console.ReadKey();
        }
    }
}
