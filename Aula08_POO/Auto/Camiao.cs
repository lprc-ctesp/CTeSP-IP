using System;

namespace Aula08_POO.Auto
{
    internal class Camiao : Veiculo
    {
        public Camiao(int modelo, double preco) : base(modelo, preco) { }

        public override void Iniciar()
        {
            Console.WriteLine("O Camião iniciou....");
        }

        public override void Acelerar()
        {
            Console.WriteLine("O camião acelerou....");
        }

        public override string ToString()
        {
            return "Camião: " + base.ToString();
        }
    }
}
