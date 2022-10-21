using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão implícita -> int to decimal");

            // Conversão implícita
            int numeroInt = 1234;
            decimal numeroDecimal = numeroInt;

            Console.WriteLine(numeroDecimal);

            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("");

            Console.WriteLine("Conversão explícita -> double to int");

            // Conversão explícita
            double numeroDouble = 123.4;
            numeroInt = (int)numeroDouble;

            Console.WriteLine(numeroInt);

            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("");

            Console.WriteLine("Conversão com classe auxiliar -> string to int");

            // Conversão com classe auxiliar
            string numeroString = "123456";
            numeroInt = Convert.ToInt32(numeroString);
            Console.WriteLine(numeroInt);

            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("");

            // int.Parse()

            Console.WriteLine("Utilizar parse sem erros - \"100\"");
            string valor1 = "100";
            int valor2 = int.Parse(valor1);
            Console.WriteLine(valor2);

            //Console.WriteLine("Lança a exceção ArgumentNullException - tenta converter null em int");
            //valor1 = null;
            //valor2 = int.Parse(valor1);

            //Console.WriteLine("Lança a exceção FormatException - tenta converter decimal em int");
            //valor1 = "100.99";
            //valor2 = int.Parse(valor1);

            //Console.WriteLine("Lança a exceção OverflowException - número maior que um tipo int suporta");
            //valor1 = "999999999999999999999999999999";
            //valor2 = int.Parse(valor1); 

            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("");

            // int.TryParse()

            Console.WriteLine("O valor é convertido sem erros.");
            string valor3 = "100";
            int resultado = 0;
            bool sucesso = int.TryParse(valor3, out resultado);
            Console.WriteLine(sucesso);
            Console.WriteLine("");

            Console.WriteLine("Conversão falhou.\r\nresultado = 0 e sucesso = false");
            valor3 = null;
            sucesso = int.TryParse(valor3, out resultado);
            Console.WriteLine(sucesso);
            Console.WriteLine("");

            Console.WriteLine("Conversão falhou.\r\nresultado = 0 e sucesso = false");
            valor3 = "100.99";
            sucesso = int.TryParse(valor3, out resultado);
            Console.WriteLine(sucesso);
            Console.WriteLine("");

            Console.WriteLine("Conversão falhou.\r\nResultado = 0 e sucesso = false");
            valor3 = "999999999999999999999";
            sucesso = int.TryParse(valor3, out resultado);
            Console.WriteLine(sucesso);
            Console.WriteLine("");

            Console.Read();
        }
    }
}
