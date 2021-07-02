using System;

namespace CalculadoraConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            string operacao;


            Program.ExibeDesenhoCalculadora();
            do
            {
                Program.ApresentaCalculadora();

                Console.WriteLine("Digite a Operação desejada.");
                operacao = (Console.ReadLine());
                Console.WriteLine();




                switch (operacao)
                {
                    case "1":
                        soma();
                        break;

                    case "2":
                        subtracao();
                        break;

                    case "3":
                        multiplicacao();
                        break;

                    case "4":
                        divisao();
                        break;

                    case "5":
                        exponenciacao();
                        break;

                    case "6":
                        radiacao();
                        break;

                    case "7":
                        sobre();
                        break;

                    case "0":
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine("Obrigado por utilizar nosso programa!");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Escolha uma opção válida");
                        Console.ResetColor();
                        Console.ReadKey();
                        break;
                }
            } while (operacao != "0");
        }
        static void ExibeDesenhoCalculadora()
        {
            Console.Clear();a
            Console.WriteLine("Bem vindo a NS Calculadora");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("╔═══════════════╗");
            Console.WriteLine("╠══Calculadora══╣");
            Console.WriteLine("║ MC| MR| M-| M+║");
            Console.WriteLine("║ 1 | 2 | 3 | ÷ ║");
            Console.WriteLine("║ 4 | 5 | 6 | X ║");
            Console.WriteLine("║ 7 | 8 | 9 | - ║");
            Console.WriteLine("║   0   | = | + ║");
            Console.WriteLine("╚═══════════════╝");
            Console.ResetColor();
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadKey();
        }
        static void ApresentaCalculadora()
        {
            Console.WriteLine("----Operações Abaixo----");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine("║ '1' Para soma (+)            ║");
            Console.WriteLine("║ '2' Para Subtração (-)       ║");
            Console.WriteLine("║ '3' Para Multiplicação (x)   ║");
            Console.WriteLine("║ '4' Para Divisão (÷)         ║");
            Console.WriteLine("║ '5' Para Exponenciação (x²)  ║");
            Console.WriteLine("║ '6' Para Radiação (√)        ║");
            Console.WriteLine("║                              ║");
            Console.WriteLine("║ '7' Sobre                    ║");
            Console.WriteLine("║ '0' Para Sair do Programa    ║");
            Console.WriteLine("╚══════════════════════════════╝");
            Console.ResetColor();

        }
        static void FinalizaPrograma()

        {
            Console.WriteLine("Pressione uma tecla para Finalizar o Programa...");
            Console.ReadKey();
            Environment.Exit(-1);
        }
        static void soma()
        {
            bool numero1val, numero2val;
            double numero1, numero2, resultado;

            Console.Write("Digite o Primeiro número:");
            numero1val = Double.TryParse(Console.ReadLine(), out numero1);

            if (!numero1val)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nDigite um Número Válido.");
                Console.ResetColor();
                Console.ReadKey();
                Environment.Exit(-1);
            }

            Console.Write("Digite o Segundo número.:");
            numero2val = Double.TryParse(Console.ReadLine(), out numero2);

            if (!numero2val)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nDigite um Número Válido.");
                Console.ResetColor();
                Console.ReadKey();
                Environment.Exit(-1);

            }

            resultado = numero1 + numero2;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n{numero1} + {numero2} = {resultado}\n");
            Console.ResetColor();

            FinalizaPrograma();



        }
        static void subtracao()
        {
            bool numero1val, numero2val;
            double numero1, numero2, resultado;

            Console.Write("Digite o Primeiro número:");
            numero1val = Double.TryParse(Console.ReadLine(), out numero1);

            if (!numero1val)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nDigite um Número Válido.");
                Console.ResetColor();
                Console.ReadKey();
                Environment.Exit(-1);
            }

            Console.Write("Digite o Segundo número.:");
            numero2val = Double.TryParse(Console.ReadLine(), out numero2);

            if (!numero2val)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nDigite um Número Válido.");
                Console.ResetColor();
                Console.ReadKey();
                Environment.Exit(-1);

            }

            resultado = numero1 - numero2;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n{numero1} - {numero2} = {resultado}\n");
            Console.ResetColor();


            FinalizaPrograma();

        }
        static void multiplicacao()
        {
            bool numero1val, numero2val;
            double numero1, numero2, resultado;

            Console.Write("Digite o Primeiro número:");
            numero1val = Double.TryParse(Console.ReadLine(), out numero1);

            if (!numero1val)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nDigite um Número Válido.");
                Console.ResetColor();
                Console.ReadKey();
                Environment.Exit(-1);
            }

            Console.Write("Digite o Segundo número.:");
            numero2val = Double.TryParse(Console.ReadLine(), out numero2);

            if (!numero2val)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nDigite um Número Válido.");
                Console.ResetColor();
                Console.ReadKey();
                Environment.Exit(-1);

            }

            resultado = numero1 * numero2;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n{numero1} x {numero2} = {resultado}\n");
            Console.ResetColor();


            FinalizaPrograma();

        }
        static void divisao()
        {
            bool numero1val, numero2val;
            double numero1, numero2, resultado;

            Console.Write("Digite o Primeiro número:");
            numero1val = Double.TryParse(Console.ReadLine(), out numero1);

            if (!numero1val)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nDigite um Número Válido.");
                Console.ResetColor();
                Console.ReadKey();
                Environment.Exit(-1);
            }

            Console.Write("Digite o Segundo número.:");
            numero2val = Double.TryParse(Console.ReadLine(), out numero2);

            if (!numero2val)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nDigite um Número Válido.");
                Console.ResetColor();
                Console.ReadKey();
                Environment.Exit(-1);

            }

            resultado = numero1 / numero2;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\n{numero1} ÷ {numero2} = {resultado}\n");
            Console.ResetColor();


            FinalizaPrograma();

        }
        static void exponenciacao()
        {
            bool numero1val;
            double numero1, resultado;

            Console.Write("Digite o Número que deseja Exponenciar:");
            numero1val = Double.TryParse(Console.ReadLine(), out numero1);

            if (!numero1val)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nDigite um Número Válido.");
                Console.ResetColor();
                Console.ReadKey();
                Environment.Exit(-1);
            }

            resultado = Math.Pow(numero1, 2);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nO Número {numero1}² = {resultado}\n");
            Console.ResetColor();


            FinalizaPrograma();

        }
        static void radiacao()

        {
            bool numero1val;
            double numero1, resultado;

            Console.Write("Digite o Número que deseja Radiar:");
            numero1val = Double.TryParse(Console.ReadLine(), out numero1);

            if (!numero1val)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nDigite um Número Válido.");
                Console.ResetColor();
                Console.ReadKey();
                Environment.Exit(-1);
            }

            resultado = Math.Sqrt(numero1);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nA Raiz Quadrada de {numero1} = {resultado}\n");
            Console.ResetColor();

            FinalizaPrograma();

        }
        static void sobre()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Site do Projeto > https://natansantos155.github.io/CalculadoraConsole/");
            Console.WriteLine("Desenvolvedor > Natã dos Santos Silva");
            Console.WriteLine("GitHub > https://github.com/NatanSantos155\n");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Agradecimentos");
            Console.WriteLine("Prof. Neri");
            Console.WriteLine("Prof. Ermogenes");
            Console.WriteLine("Etec Adolpho Berezin");
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
