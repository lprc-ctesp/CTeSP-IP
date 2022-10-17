using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "alias string"; // criando a string usando a palavra-chave string 
            String s2 = "alias String"; // criando a string usando a classe String 
            System.String s3 = "System.String"; // criando a string usando a classe String 

            // Length
            Console.WriteLine("Length");
            Console.WriteLine("");
            string name = "Luiz Carvalho";
            Console.WriteLine("Nome: " + name + " tem " + name.Length + " letras");

            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("");

            // Concat
            string str1 = "C# ";
            Console.WriteLine("string str1: " + str1);
                        
            string str2 = "Programming";
            Console.WriteLine("string str2: " + str2);

            // join two strings
            string joinedString = string.Concat(str1, str2);
            Console.WriteLine("String concatenadas: " + joinedString);

            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("");

            // Equals
            string str3 = "C# Programming";
            string str4 = "C# Programming";
            string str5 = "Programa";
            Console.WriteLine("str3 = \"C# Programming\"");
            Console.WriteLine("str4 = \"C# Programming\"");
            Console.WriteLine("str5 = \"Programa\"");
            Console.WriteLine("");

            // compara str3 e str4
            Boolean result1 = str3.Equals(str4);
            Console.WriteLine("As strings str3 e str4 são iguals? " + result1);

            //compara str3 e str5
            Boolean result2 = str3.Equals(str5);
            Console.WriteLine("As strings str3 e str5 são iguais? " + result2);

            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("");

            // Scape

            // Aspas duplas incluídas
            // string str = "This is the "String" class"; // Erro

            string scape = "This is the \"String\" class"; // Correto - Use de \
            Console.WriteLine(scape);

            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("");

            // Interpolation
            string interpolation = "CTeSP";

            // string interpolation
            string mensagem = $"Bem vindos ao {interpolation}";
            Console.WriteLine(mensagem);

            Console.Read();

        }
    }
}
