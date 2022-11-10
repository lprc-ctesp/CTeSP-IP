using System;

namespace IP_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var isFinished = false;

            do
            {
                // Solicita ao utilizador uma opção (exercício) para executar 
                Console.WriteLine("Digite uma opção para exibir o resultado do exercício");
                Console.WriteLine(" ");
                Console.WriteLine("Para calcular a área do retângulo, digite: 1");
                Console.WriteLine("Para saber o salário liquido, digite: 2");
                Console.WriteLine("Para calcular o fatorial de um número, digite: 3");
                Console.WriteLine("Para calcular a área do triângulo, digite: 4");
                Console.WriteLine("Para saber o salário liquido de acordo com o escalão, digite: 5");
                Console.WriteLine("Para saber o salário liquido com os descontos discriminados, digite: 6");
                Console.WriteLine("Para calcular o fatorial de um número utilizando a instrução FOR, digite: 7");
                Console.WriteLine("Para o Exercício 08 (explicação de sufixo), digite: 8");

                Console.Write("Opção: ");
                string numExercicio = Console.ReadLine();
                Console.WriteLine(" ");

                /*
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
                                // Não preciso fassar informação como "false" porque já é um valor por defeito.
                                CalcularAreaDoPoligono();
                                break;
                            }
                        case 2:
                            {
                                Console.Write("Informe o salário bruto: ");
                                Console.WriteLine("Líquido: " + CalculoSalarioLiquido(double.Parse(Console.ReadLine())));
                                break;
                            }
                        case 3:
                            {
                                var fatorial = CalcularFatorial();
                                if (fatorial > 0)
                                {
                                    Console.WriteLine("Fatorial: " + fatorial);
                                }
                                else
                                {
                                    /*
                                    * Este comando chama outro case dentro do switch.
                                    * Para nosso caso, caso o utilizador selecione qualquer outra dado que nao seja inteiro,
                                    * ao invés de fechar o sistema, chamo novamnente o case 3 para que o utilizador possa digitar novamente.
                                    */

                                    goto case 3;
                                }

                                break;
                            }
                        case 4:
                            {
                                CalcularAreaDoPoligono(true);
                                break;
                            }
                        case 5:
                            {
                                CalculoSalarioLiquidoComEscalao();
                                break;
                            }
                        case 6:
                            {
                                CalculoSalarioLiquidoComDescontoDiscriminado();
                                break;
                            }
                        case 7:
                            {
                                // CalcularFatorial(true);
                                // ou                                
                                var fatorial = CalcularFatorial(isForInstruction: true);
                                if (fatorial > 0)
                                {
                                    Console.WriteLine("Fatorial: " + fatorial);
                                }
                                else
                                {
                                    /*
                                    * Este comando chama outro case dentro do switch.
                                    * Para nosso caso, caso o utilizador selecione qualquer outra dado que nao seja inteiro,
                                    * ao invés de fechar o sistema, chamo novamnente o case 3 para que o utilizador possa digitar novamente.
                                    */

                                    goto case 7;
                                }

                                break;
                            }
                        case 8:
                            {
                                ExplicacaoDeSufixo();
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

                Console.WriteLine("");
                Console.WriteLine("Deseja finalizar o exercício? Se sim, prima \"S\"");

                // ToUpper é um método interno da classe string que coloca as letras em maiúscula. Assim se o utilizador digitar "s" ou "S" não fará diferença para o sistema.
                isFinished = Console.ReadLine().ToUpper() == "S";
                Console.WriteLine("");

            } while (!isFinished);


            Environment.Exit(0);
        }

        // para separar um bloco de código por região digite -> #region NomeDaRegião
        // Coloque o código
        // No final digite #endregion
        #region Exercício 1 e 4
        /// <summary>
        /// Calcular a Área de um Polígono (triângulo ou Retângulo)
        /// </summary>
        /// <param name="isTriangulo">Informa se o polígono é um triângulo ou não.</param>
        /// <returns></returns>
        public static void CalcularAreaDoPoligono(bool isTriangulo = false)
        {
            bool isValidNumber;

            Console.Write("Qual o comprimento? ");
            isValidNumber = int.TryParse(Console.ReadLine(), out int comprimento);

            while (!isValidNumber)
            {
                Console.Write("Digite um número válido para o comprimento: ");
                isValidNumber = int.TryParse(Console.ReadLine(), out comprimento);
            }

            Console.Write("Qual a altura? ");
            isValidNumber = int.TryParse(Console.ReadLine(), out int altura);

            while (!isValidNumber)
            {
                Console.Write("Digite um número válido para o comprimento: ");
                isValidNumber = int.TryParse(Console.ReadLine(), out altura);
            }

            var area = comprimento * altura;
            Console.WriteLine("A área é igual a " + (isTriangulo ? area / 2D : area));
            Console.WriteLine("");
        }
        #endregion

        #region Exercício 2

        /// <summary>
        /// Calculo do Salario Líquido
        /// </summary>
        /// <param name="salarioBruto">Salário bruto do funcionário</param>
        /// <returns></returns>
        public static double CalculoSalarioLiquido(double salarioBruto)
        {   
            double segSocial, irs;

            segSocial = salarioBruto * 0.2;

            if (salarioBruto < 500)
            {
                irs = 0;
            }
            else if (salarioBruto >= 500 && salarioBruto < 1000)
            {
                irs = salarioBruto * 0.12;
            }
            else if (salarioBruto >= 1000 && salarioBruto < 1500)
            {
                irs = salarioBruto * 0.15;
            }
            else
            {
                irs = salarioBruto * 0.18;
            }

            return salarioBruto - (irs + segSocial);
        }
        #endregion

        #region Exercício 3 e 7

        /// <summary>
        /// Calculo Fatorial de um Número
        /// </summary>        
        /// <returns></returns>
        public static int CalcularFatorial(bool isForInstruction = false)
        {
            var resultado = 0;
            Console.Write("Prima o número para calcular: ");

            if (int.TryParse(Console.ReadLine(), out int numeroFatorial))
            {
                // Aqui temos o IF aninhado. 
                // Condição ? processo se condição verdadeira : processo se consição falsa
                // O "?" define o primeiro processo e o ":" o segundo se condiçâo falsa.
                // Seria o mesmo que if { se condição verdadeira } else { se condoção falsa }
                resultado = isForInstruction ? FatorialComFor(numeroFatorial) : FatorialComWhile(numeroFatorial);
                            // Se ...        // então ...                     // senão ...
            }
            
            return resultado;
        }

        public static int FatorialComWhile(int numeroFatorial)
        {
            var fatorial = 1;

            while (numeroFatorial > 1)
            {
                fatorial = fatorial * numeroFatorial;
                numeroFatorial--;
            }

            return fatorial;
        }

        public static int FatorialComFor(int numeroFatorial)
        {
            var fatorial = 1;
            for (int valor = numeroFatorial; valor >= 1; valor--)
            {
                fatorial = fatorial * valor;
            }

            return fatorial;
        }

        #endregion

        #region Exercício 5

        /// <summary>
        /// Calculo do Salario Líquido com Escalao
        /// </summary>
        /// <returns></returns>
        public static void CalculoSalarioLiquidoComEscalao()
        {
            double liquido = 0;
            int escalaoIrs;

            Console.Write("Salário Bruto: ");
            var bruto = double.Parse(Console.ReadLine());
            
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

            var segSocial = bruto * 0.2;

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
        }
        #endregion

        #region Exercício 6

        /// <summary>
        /// Calculo do Salario Líquido com desconto discriminado
        /// </summary>
        /// <returns></returns>
        public static void CalculoSalarioLiquidoComDescontoDiscriminado()
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
        }
        #endregion

        #region Exercício 8

        /// <summary>
        /// Explicacao De Sufixo Real
        /// </summary>
        public static void ExplicacaoDeSufixo()
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
        }
        #endregion

    }
}
