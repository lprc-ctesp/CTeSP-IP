using System;

namespace Aula07_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var r = new Retangulo();

            Console.WriteLine("Informe o comprimento: ");
            r.Comprimento = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Informe a largura : ");
            r.Largura = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"Area do Retangulo: {r.GetArea()}");

            




            Cliente cliente1 = new Cliente();
            cliente1.firstName = "Clark";
            cliente1.lastName = "Kent";
            cliente1.phoneNumber = "98745632";
            cliente1.emailAddress = "clarkkent@email.com";

            Console.WriteLine("First name is " + cliente1.firstName);

            Console.ReadKey();
        }
    }

    public class Cliente
    {
        public string firstName;
        public string lastName;
        public string phoneNumber;
        public string emailAddress;

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
    }

    public class Fruta
    {
        public string Nome { get; set; }
        public string Cor { get; set; }
    }

    public class Laranja : Fruta
    {
        public int NumeroDeSementes { get; set; }
    }

    public class ContaBancaria2
    {
        private double Saldo { get; set; }
    }

    public class ContaBancaria
    {
        private double Saldo { get; set; }
        private double Taxas { get; set; }

        public double GetSaldo()
        {
            double saldoComTaxa = GetSaldoComTaxa();
            return saldoComTaxa;
        }

        private double GetSaldoComTaxa()
        {
            return Saldo * Taxas;
        }
    }

    public class Retangulo
    {
        private double comprimento;
        private double largura;
        public double Comprimento
        {
            get { return comprimento; }            
        }
        public double Largura
        {
            get { return largura; }
            set
            {
                if (value < 0) Console.WriteLine("O valor da largura não pode ser menor que zero");
                else largura = value;
            }
        }
        public double GetArea()
        {
            return Comprimento * Largura;
        }


        public abstract class Veiculo
        {
            public abstract int GetNumeroDePneus();
        }

        public class Bicicleta : Veiculo
        {
            private int NumeroDePneus = 2;
            public string Fabricante { get; set; }
            public string Modelo { get; set; }
            public int NumeroDeÃssento { get { return 2; } }
            public override int GetNumeroDePneus()
            {
                return NumeroDePneus;
            }
        }

        public class Carro : Veiculo
        {
            public string Fabricante { get; set; }
            public string Modelo { get; set; }
            public int PneusDianteiros { get; set; }
            public int PneusTraseiros { get; set; }

            public override int GetNumeroDePneus()
            {
                return PneusDianteiros + PneusTraseiros;
            }
        }


        public class calculadora
        {
            public int AddNumeros(int primeiroNumero, int segundoNumero)
            {
                return primeiroNumero + segundoNumero;
            }

            public double AddNumeros(double primeiroNumero, double segundoNumero)
            {
                return primeiroNumero + segundoNumero;
            }
        }

        public class MinhaCalculadora
        {
            public int a;
            public int b;

            public MinhaCalculadora(int a, int b)
            {
                this.a = a;
                this.b = b;
            }

            public static MinhaCalculadora operator +(MinhaCalculadora a, MinhaCalculadora b)
            {
                return new MinhaCalculadora(a.a * 3, b.b * 3);
            }
        }

    }
}
