using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao utilizador uma opção (exercício) para executar 
            Console.WriteLine("Digite uma opção para exibir o resultado do exercício");
            Console.WriteLine(" ");
            Console.WriteLine("Para o Exercício 01 digite: 1");
            Console.WriteLine("Para o Exercício 02 digite: 2");
            Console.WriteLine("Para o Exercício 03 digite: 3");
            Console.WriteLine("Para o Exercício 04 digite: 4");
            Console.WriteLine("Para o Exercício 05 digite: 5");
            Console.WriteLine("Para o Exercício 06 digite: 6");
            Console.WriteLine("Para o Exercício 07 digite: 7");
            Console.WriteLine("Para o Exercício 08 digite: 8");
            Console.WriteLine(" ");

            Console.Write("Opção: ");
            string numExercicio = Console.ReadLine();
            Console.WriteLine(" ");

            if (int.TryParse(numExercicio, out int numero))
            {
                /*
                 * Ao acessar o switch, prova-se que a validação acima foi validada positivamente.
                 * Porém, caso não tenha opção numérica, por exemplo opção 10, o processamento vai para a opção default
                 * No default é exibido a mensagem ao utilizador de exercício inexistente
                 */
                switch (numero)
                {
                    case 1:
                        {
                            Console.Write("Digite um número inteiro: ");

                            int num = int.Parse(Console.ReadLine());
                            Console.WriteLine($"O sucessor de {num} é {++num}");

                            break;
                        }
                    case 2:
                        {
                            float numcig, anos, preço; // numcig = número de cigarros

                            Console.WriteLine("Digite o numero de cigarros que fuma por dia.");
                            numcig = float.Parse(Console.ReadLine());

                            Console.WriteLine("Digite a quantidade de anos que fuma.");
                            anos = float.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o preço do maço de cigarro.");
                            preço = float.Parse(Console.ReadLine());

                            Console.WriteLine();

                            if (preço > 0)
                            {
                                float soma = (365 * anos * (numcig / 20)) * preço;
                                Console.Write(String.Format("Gastaste {0} euros com cigarros.", Math.Round(soma, 2)));
                            }
                            else
                            {
                                Console.WriteLine("Você digitou o valor do maço de cigarros errado.");
                            }

                            break;
                        }
                    case 3:
                        {

                            int x, y, resto = 0, quociente = 0;

                            Console.WriteLine("Digite um valor inteiro para x");
                            x = int.Parse(Console.ReadLine());

                            Console.WriteLine("Digite um valor inteiro para x");
                            y = int.Parse(Console.ReadLine());

                            if (y == 0)
                            {
                                Console.WriteLine("Não há divisão por zero.");
                            }
                            else
                            {
                                quociente = x / y;
                                resto = x % y;
                                Console.WriteLine("O quociente é = " + quociente + " e o resto é = " + resto);
                            }

                            break;
                        }
                    case 4:
                        {

                            Console.Write("Digite um valor interio para x: ");
                            int x = int.Parse(Console.ReadLine());

                            Console.Write("Digite um valor interio para y: ");
                            int y = int.Parse(Console.ReadLine());

                            if (x % y == 0)
                            {
                                Console.WriteLine("X é multiplo de Y");
                            }
                            else
                            {
                                Console.WriteLine("X não é multiplo de Y");
                            }

                            break;
                        }
                    case 5:
                        {
                            int a, b, c, maiorNumero = 0;

                            Console.Write("Digite a primeiro número: ");
                            a = int.Parse(Console.ReadLine());

                            Console.Write("Digite a segundo número: ");
                            b = int.Parse(Console.ReadLine());

                            Console.Write("Digite a terceiro número: ");
                            c = int.Parse(Console.ReadLine());

                            if (a > b && a > c)
                            {
                                maiorNumero = a;
                            }
                            if (b > a && b > c)
                            {
                                maiorNumero = b;
                            }
                            if (c > a && c > b)
                            {
                                maiorNumero = c;
                            }

                            Console.WriteLine("O maior número é " + maiorNumero);

                            break;
                        }
                    case 6:
                        {
                            int num = 0, soma = 0;
                            for (int x = 0; x < 4; x++)
                            {
                                Console.Write("Digite um número: ");
                                num = int.Parse(Console.ReadLine());

                                if (num % 2 == 0)
                                {
                                    soma += num;
                                }
                            }

                            Console.WriteLine();
                            Console.WriteLine($"A soma dos números pares é: {soma}");

                            break;
                        }
                    case 7:
                        {
                            String matriculaMaiorAluno, matriculaMenorAluno, matricula;
                            Double alturaMaiorAluno, alturaMenorAluno, altura;

                            Console.WriteLine("Determina o maior aluno e o menor aluno");
                            Console.Write("Informe a matricula do aluno: ");
                            matricula = Console.ReadLine();

                            Console.Write("Informe a altura do aluno: ");
                            altura = Convert.ToDouble(Console.ReadLine());

                            alturaMaiorAluno = altura;
                            alturaMenorAluno = altura;
                            matriculaMaiorAluno = matricula;
                            matriculaMenorAluno = matricula;

                            Console.WriteLine();

                            int i = 1;
                            while (i < 5)
                            {
                                Console.Write("Informe a matricula do aluno: ");
                                matricula = Console.ReadLine();

                                Console.Write("Informe a altura do aluno: ");
                                altura = Convert.ToDouble(Console.ReadLine());
                                
                                if (alturaMaiorAluno < altura)
                                {
                                    matriculaMaiorAluno = matricula;
                                    alturaMaiorAluno = altura;
                                }

                                if (alturaMenorAluno > altura)
                                {
                                    matriculaMenorAluno = matricula;
                                    alturaMenorAluno = altura;
                                }
                                i++;
                                Console.WriteLine();
                            }
                            Console.WriteLine("Maior aluno:");
                            Console.WriteLine("Matrícula: {0}, Altura: {1}", matriculaMaiorAluno, alturaMaiorAluno);
                            Console.WriteLine();
                            Console.WriteLine("Menor aluno:");
                            Console.WriteLine("Matrícula: {0}, Altura: {1}", matriculaMenorAluno, alturaMenorAluno);

                            break;
                        }
                    case 8:
                        {
                            int tamanho;

                            Console.WriteLine("Informe o tamanho da Matrix Identidade: ");
                            tamanho = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nMatrix Identidade\n");

                            for (int i = 0; i < tamanho; i++)
                            {
                                for (int j = 0; j < tamanho; j++)
                                {
                                    if (i == j)
                                    {
                                        Console.Write(1);
                                    }
                                    else
                                    {
                                        Console.Write(0);
                                    }
                                }
                                Console.WriteLine();
                            }

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Exercício inexistente!");
                            break;
                        }
                }
            }
            else
            {
                Console.WriteLine("Opção incorreta! Tente novamente");
            }

            Console.Read();
        }
    }
}
