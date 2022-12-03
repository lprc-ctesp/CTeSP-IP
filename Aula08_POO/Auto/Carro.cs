using System;

namespace Aula08_POO.Auto
{
    internal class Carro : Veiculo
    {
        public Carro(int modelo, double preco) : base(modelo, preco) { }

        //Implementação do método abstrato Iniciar()
        public override void Iniciar() 
        {
            Console.WriteLine("O carro iniciou....");
        }

        //Implementação do método abstrato Acelerar()
        public override void Acelerar()
        {
            Console.WriteLine("O carro acelerou....");
        }

        public override string ToString()
        {
            return "Carro: " + base.ToString();
        }
    }
}
