namespace Aula08_POO.Auto
{
    abstract class Veiculo
    {
        private int matricula;
        private int modelo;
        private double preco;
        private static int numeroSerie = 0;

        public int Matricula
        {
            get { return matricula; }
        }

        public int Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public static int NumeroSerie
        {
            get { return numeroSerie; }
        }

        public Veiculo(int modelo, double preco)
        {
            numeroSerie++;
            matricula = numeroSerie;
            this.modelo = modelo;
            this.preco = preco;
        }

        public abstract void Iniciar();
        public abstract void Acelerar();

        public override string ToString()
        {
            return "Matrícula: " + matricula + " Modelo: " + modelo + " Preço: " + preco;
        }
    }
}
