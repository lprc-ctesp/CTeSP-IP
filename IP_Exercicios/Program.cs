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
            Console.WriteLine("Para o Exercício 04 digite: 4");
            Console.WriteLine("Para o Exercício 05 digite: 5");
            Console.WriteLine("Para o Exercício 06 digite: 6");
            Console.WriteLine("Para o Exercício 07 digite: 7");
            Console.WriteLine("Para o Exercício 08 digite: 8");

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
                            else if (bruto >= 1000 && bruto < 1500)
                            {
                                irs = bruto * 0.15;
                            }
                            else
                            {
                                irs = bruto * 0.18;
                            }

                            liquido = bruto  - (irs + segSocial);

                            Console.WriteLine("Líquido: " + liquido);

                            break;
                        }
                    case 3:
                        {
                            // F=5x4x3x2x1
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
                    case 4:
                        {
                            int comprimento, altura;
                            double area;

                            Console.Write("Qual o comprimento? ");
                            comprimento = int.Parse(Console.ReadLine());

                            Console.Write("Qual a altura? ");
                            altura = int.Parse(Console.ReadLine());

                            area = (comprimento * altura) / 2D;

                            Console.WriteLine("A área é igual a " + area);
                            Console.WriteLine("");

                            break;
                        }
                    case 5:
                        {
                            double bruto, segSocial, liquido = 0;
                            int escalaoIrs;

                            Console.Write("Salário Bruto: ");
                            bruto = double.Parse(Console.ReadLine());

                            segSocial = bruto * 0.2;
                            if (bruto < 500)
                            {
                                escalaoIrs = 1;
                            }
                            else if (bruto >= 500 && bruto < 1000)
                            {
                                escalaoIrs = 2;
                            }
                            else if (bruto >= 1000 && bruto < 1500)
                            {
                                escalaoIrs = 3;
                            }
                            else
                            {
                                escalaoIrs = 4;
                            }

                            switch (escalaoIrs)
                            {
                                case 1:
                                    liquido = bruto - segSocial;
                                    break;
                                case 2:
                                    liquido = bruto - segSocial - bruto * 0.12;
                                    break;
                                case 3:
                                    liquido = bruto - segSocial - bruto * 0.15;
                                    break;
                                case 4:
                                    liquido = bruto - segSocial - bruto * 0.18;
                                    break;
                            }

                            Console.WriteLine("Líquido: " + liquido);

                            break;
                        }
                    case 6:
                        {
                            double bruto, segSocial, irs = 0, liquido = 0;
                            int escalaoIrs;

                            Console.Write("Salário Bruto: ");
                            bruto = double.Parse(Console.ReadLine());

                            segSocial = bruto * 0.2;
                            if (bruto < 500)
                            {
                                escalaoIrs = 1;
                            }
                            else if (bruto >= 500 && bruto < 1000)
                            {
                                escalaoIrs = 2;
                            }
                            else if (bruto >= 1000 && bruto < 1500)
                            {
                                escalaoIrs = 3;
                            }
                            else
                            {
                                escalaoIrs = 4;
                            }

                            switch (escalaoIrs)
                            {
                                case 1:
                                    liquido = bruto - segSocial;
                                    break;
                                case 2:
                                    irs = bruto * 0.12;
                                    liquido = bruto - segSocial - irs;
                                    break;
                                case 3:
                                    irs = bruto * 0.15;
                                    liquido = bruto - segSocial - irs;
                                    break;
                                case 4:
                                    irs = bruto * 0.18;
                                    liquido = bruto - segSocial - irs;
                                    break;
                            }

                            Console.WriteLine("Seg. Social: " + segSocial);
                            Console.WriteLine("IRS: " + irs);
                            Console.WriteLine("Líquido: " + liquido);

                            break;
                        }
                    case 7:
                        {
                            long num, fatorial = 1;

                            Console.Write("Número: ");
                            num = long.Parse(Console.ReadLine());

                            for (long valor = num; valor >= 1; valor--)
                            {
                                fatorial = fatorial * valor;
                            }

                            Console.WriteLine("Fatorial: " + fatorial);

                            break;
                        }
                    case 8:
                        {
                            /* 
                             * 
                             * Os sufixos Literais Reais é utilizado para atribuir ou comparar números diretamente no código (Hard Coded).
                             * 
                             * O sufixo especifica o tipo do número, eles servem para instruir ao compilador C# qual o formato literal do 
                             * número, por exemplo 1000 pode ser considerado alguns tipos diferentes de número (inteiro, long, double).
                             * 
                             * Um problema pode ser o seguinte:
                             * 
                             * Imaginemos que uma empresa teve um lucro de 2.548.741,57 euros e precisa dividir para os seus grupos 
                             * de investidores.
                             *  
                            */

                            // ---------------------------------------------------------------------------------------------------------
                            // Desenvolvimento
                            // ---------------------------------------------------------------------------------------------------------

                            /* 
                             * Primeira observação. Sempre que for trabalhar com valores (dinheiro ou finanças), utilizem o decimal.
                             * O tipo decimal é o ÚNICO tipo que tem a precisão adequada para evitar os erros críticos de arredondamento.
                             * 
                             * Para o exemplo abaixo:
                             * 
                             * decimal lucro = 2548741.57;
                             * 
                             * decimal lucro = 2548741.57; (Sem o sufixo "M") - Vai gerar erro, pois como expliquei em sala de aula, 
                             * o compilador C#, sempre vai atribuir ao literal o tipo de dados conforme uma ordem preestabelecida.
                             * (PDF IP-Aula_03-11_10, página 18)
                             * 
                             * Assim, se tirarmos o "M" o compilador do C# vai reconhecer o tipo do valor como double e será gerado um erro
                             * de conversão de tipo.
                             * 
                             * Para o exemplo (decimal lucro = 2548741.57;), se descomentares irá ser noificado sober algum erro
                             * de compilação e se colocares o rato sobre a marca vermelha de erro, será exibido:
                             * 
                             * Error -> Literal of type double cannot be implicitly converted to type 'decimal'; 
                             * use an 'M' suffix to create a literal of this type.
                             * 
                             * Ou seja, o próprio sistema irá indicar o sufixo adequado.
                             *
                             *                            
                             * Entretanto, se colocarmos o sufixo "M" ou "m", o sistema irá reconhecer o dado literal especificado.
                             */

                            decimal lucro = 2548741.57M;
                            Console.WriteLine("");

                            // Exibe para o utilizador o nome do tipo do número
                            Console.WriteLine($"O tipo do valor 2548741.57 é: {(2548741.57).GetType().Name}");
                            Console.WriteLine("");
                            Console.WriteLine($"O tipo do valor 2548741.57M é: {(2548741.57m).GetType().Name}");                            
                            Console.WriteLine("");

                            /*
                             * Agora, sobre o exercício 4 podemos observar o seguinte:
                             * 
                             * area = (comprimento * altura) / 2D;
                             * 
                             * A variável (area) é double.
                             * A variável comprimento e altura são inteiros.
                             * 
                             * Ou seja, se dividirmos um inteiro por outro inteiro, o resultado será um inteiro, assim iremos desprezar as 
                             * casas decimais.
                             * 
                             * Por isso que é preciso colocar o "D" ou "d" logo após o 2 (2D ou 2d). Pois assim o copilador entenderá que a
                             * divisão deverá resultar em um double e as casas decimais irão ser consideradas.
                             * 
                             * Agora, imeginemos que a área seja 18 (9 x 2). Na divisão, por 3, mesmo sendo double ou inteiro, retornará
                             * 6 como double
                             * 
                             * Entretato, imeginemos que a área seja 35 (5 x 7). Na divisão, por 3. Se não tiver sufixo, um valor será inteiro
                             * (sem casas decimais) enquanto que o número com sufixo será com decimal (double)
                             *
                             */
                            
                            double area;

                            area = (9 * 2) / 3;

                            Console.WriteLine($"Resultado de area = (9 * 2) / 3 é: {area} e o tipo {area.GetType().Name}");
                            Console.WriteLine("");

                            area = (9 * 2) / 3D;

                            Console.WriteLine($"Resultado de area = (9 * 2) / 3D é: {area} e o tipo {area.GetType().Name}");
                            Console.WriteLine("");

                            area = (5 * 7) / 3;

                            Console.WriteLine($"Resultado de area = (5 * 7) / 3 é: {area} e o tipo {area.GetType().Name}");
                            Console.WriteLine("");

                            area = (5 * 7) / 3D;

                            Console.WriteLine($"Resultado de area = (5 * 7) / 3D é: {area} e o tipo {area.GetType().Name}");
                            Console.WriteLine("");
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
