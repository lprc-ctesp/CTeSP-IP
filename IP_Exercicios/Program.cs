using System;

namespace IP_Exercicios
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
            Console.WriteLine(" ");

            Console.Write("Opção: ");
            string numExercicio = Console.ReadLine();
            Console.WriteLine(" ");

            /* 
             *   Na linha (26) faço a validação do valor digitado numExercicio (Falaremos na próxima aula)
             *   Resumindo:
             *      - A função int.TryParse() verifica se o numExercicio digitado pelo utilizador é um inteiro.
             *      - Em caso positivo é atribuido o valor a uma variável int numero (out)
             *      - Em caso negativo (letras e caracteres) o processo vai para o "else" e diz ao utilizador que a opção está incorrata.
             */
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
                            int comprimento, altura, area;
                            Console.Write("Comprimento: ");
                            comprimento = int.Parse(Console.ReadLine());

                            Console.Write("Altura: ");
                            altura = int.Parse(Console.ReadLine());

                            area = comprimento * altura;

                            Console.WriteLine("Área: " + area);

                            break;
                        }
                    case 2:
                        {
                            double bruto, segSocial, irs, liquido;

                            Console.Write("Salário bruto: ");
                            bruto = double.Parse(Console.ReadLine());

                            segSocial = bruto * 0.2;

                            if (bruto < 500)
                            {
                                irs = 0;
                            }
                            else if (bruto >= 500 && bruto < 1000)
                            {
                                irs = bruto * 0.12;
                            }
                            else if (bruto >= 1000 && bruto > 1500)
                            {
                                irs = bruto * 0.15;
                            }
                            else
                            {
                                irs = bruto * 0.18;
                            }

                            liquido = bruto - irs;

                            Console.WriteLine("Líquido: " + liquido);

                            break;
                        }
                    case 3:
                        {
                            long num, fatorial = 1;

                            Console.Write("Número: ");
                            num = long.Parse(Console.ReadLine());

                            while (num > 1)
                            {
                                fatorial = fatorial * num;
                                num--;
                            }

                            Console.WriteLine("Fatorial: " + fatorial);

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
