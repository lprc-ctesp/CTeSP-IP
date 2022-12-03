using System;

namespace Aula08_POO
{
    internal class Pessoa
    {
        private string nome;
        private DateTime dataNascimento;
        private float altura;

        /*
         * Em outras linguagens é comum criarmos métodos get e set para cada atributo, a fim de encapsular o acesso a ele, da seguinte forma:
         * 
         *      public string getNome()
         *      {
         *          return nome;
         *      }
         * 
         *      public string setNome(string _nome)
         *      {
         *          nome = _nome;
         *      }
         */

        /*
         *
         * Em C#, porém, não costumamos criar esses métodos, ao menos não dessa forma. 
         * Isso porque no C# temos um recurso próprio da linguagem para esse fim. 
         * Aqui criamos propriedades públicas que encapsulam os atributos privados. 
         * E cada propriedade possui um método get e um set internos, da seguinte forma:
         */

         public string Nome
         {
             get
             {
                 return nome;
             }
             set
             {
                 nome = value;
             }
         }
         
         public DateTime DataNascimento
         {
             get
             {
                 return dataNascimento;
             }
             set
             {
                 dataNascimento = value;
             }
         }
         
         public float Altura
         {
             get
             {
                 return altura;
             }
             set
             {
                 altura = value;
             }
         }

        //public float Altura2 { get; set; }

        // Os métodos devem comecar com um verbo no infinitivo e ser claro e intuitivo utilizando o padrão PascalCase
        public void ImprimirDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Data de Nascimento: " + dataNascimento);
            Console.WriteLine("Data de Nascimento: " + dataNascimento.ToShortDateString());
            Console.WriteLine("Data de Nascimento: " + dataNascimento.ToString("yyyy/MM/dd"));
            Console.WriteLine("Data de Nascimento: " + dataNascimento.ToString("dd-MM-yyyy"));
            Console.WriteLine("Altura: " + altura);
        }

        public int CalcularIdade()
        {
            return DateTime.Today.Year - dataNascimento.Year;
        }
    }
}
