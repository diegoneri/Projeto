using System;

namespace Projeto
{

    public class Program 
    {
        public static void Main(string [] args)
        {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("---Calculadora básica---");
			Console.WriteLine();
			
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("--| Menu |--");
			Console.WriteLine("------------");
			Console.WriteLine();
			
			Console.ResetColor();
			
			Console.WriteLine("[S]. Soma");
			Console.WriteLine("[E]. Subtração");
			Console.WriteLine("[M]. Multiplicação");
			Console.WriteLine("[D]. Divisão");
			Console.WriteLine("[P]. Exponenciação");
			Console.WriteLine("[R]. Radiciação");
			Console.WriteLine("[I]. Menu Inicial");
			Console.WriteLine("[L]. Limpar");
			Console.WriteLine("[A]. Ajuda");
			Console.WriteLine("[X]. Sair");
			Console.WriteLine();
			
			string opcao;
			
			do
			{
			   Console.Write("Digite sua opção: ");
			   opcao = Console.ReadLine().ToUpper();
			   Console.WriteLine();
			
			   switch (opcao)
			   {
				   case "S": 
				       Console.ForegroundColor = ConsoleColor.Green;
				       Console.WriteLine("Soma\n");
				       Console.ResetColor();
				    
				       double Quantidade;
				       double Valor;
				       double Numeros = 1;
				       double Soma = 0;
				    
				       Console.Write("Digite a quantidade de números a serem somados: ");
				       Quantidade = Convert.ToDouble(Console.ReadLine());
				       Console.WriteLine();
				    
				       if (Quantidade <= 1) 
				       {
				    	   Console.WriteLine("Não é possível somar menos de 2 valores.");
				       }
				       else while (Numeros <= Quantidade)
				       {
				    	   Console.Write($"Digite o número #{Numeros}: ");
				    	   Valor = Convert.ToDouble(Console.ReadLine());
				    	
				    	   Soma += Valor;
				    	   Numeros ++;
				       }
				       Console.WriteLine();
				       Console.WriteLine($"Resultado = {Soma}");
				       Console.WriteLine();
				       
				       break;
				    
				   case "E":
				       Console.ForegroundColor = ConsoleColor.Green;
				       Console.WriteLine("Subtração\n");
				       Console.ResetColor();
				    
				       double Subtração;
				       double Numeros1 = 1;
				    
				       Console.Write("Digite o primeiro valor: ");
				       Subtração = Convert.ToDouble(Console.ReadLine());
				       Console.WriteLine();
				    
				       Console.Write("Digite a quantidade de números a serem subtraídos desse valor: ");
				       Quantidade = Convert.ToDouble(Console.ReadLine());
				       Console.WriteLine();
				    
				       if (Quantidade <= 0)
				       {
				           Console.WriteLine("Não é possível subtrair menos de um valor");
				       }
				       else while (Numeros1 <= Quantidade)
				       {
				    	   Console.Write($"Digite o número #{Numeros1}: ");
				    	   Valor = Convert.ToDouble(Console.ReadLine());
				    	
				    	   Subtração -= Valor;
				    	   Numeros1 ++;
				       }
				       Console.WriteLine();
				       Console.WriteLine($"Resultado = {Subtração}");
				       Console.WriteLine();
				       
				       break;
				
				   case "M":
				       Console.ForegroundColor = ConsoleColor.Green;
				       Console.WriteLine("Multiplicação\n");
				       Console.ResetColor();
				    
				       double M1;
				       double M2;
				       double Multiplicação;
				    
				       Console.Write("Digite o primeiro valor: ");
				       M1 = Convert.ToDouble(Console.ReadLine());
				    
				       Console.Write("Digite o segundo valor: ");
				       M2 = Convert.ToDouble(Console.ReadLine());
				    
				       Multiplicação = M1 * M2;
				    
				       Console.WriteLine();
				       Console.WriteLine($"Resultado = {Multiplicação}");
				       Console.WriteLine();
				       
				       break;
				    
				   case "D":
				       Console.ForegroundColor = ConsoleColor.Green;
				       Console.WriteLine("Divisão\n");
				       Console.ResetColor();
				    
				       double Numerador;
				       double Divisor;
				       double Divisão;
				    
				       Console.Write("Digite o numerador: ");
				       Numerador = Convert.ToDouble(Console.ReadLine());
				    
				       Console.Write("Digite o divisor: ");
				       Divisor = Convert.ToDouble(Console.ReadLine());
				    
				       Console.WriteLine();
				    
				       if (Divisor == 0)
			           {
				           Console.WriteLine("Não é possível dividir por 0");
			           }
			           else
			           {
				           Divisão = Numerador / Divisor;
				           Console.WriteLine($"Resultado = {Divisão}");
			           }
			           Console.WriteLine();
			           break;
			        
			        
			       case "P":
			           Console.ForegroundColor = ConsoleColor.Green;
			           Console.WriteLine("Exponenciação\n");
			           Console.ResetColor();
			        
			           double P1;
			           double P2;
			           double Exponenciação;
			        
			           Console.Write("Digite o numerador: ");
			           P1 = Convert.ToDouble(Console.ReadLine());
			        
			           Console.Write("Digite o expoente: ");
			           P2 = Convert.ToDouble(Console.ReadLine());
			        
			           Exponenciação = Math.Pow(P1 , P2);
			        
			           Console.WriteLine();
			           Console.WriteLine($"Resultado = {Exponenciação}");
			           Console.WriteLine();
			           
			           break;
			        
			        case "R": 
			            Console.ForegroundColor = ConsoleColor.Green;
			            Console.WriteLine("Raiz quadrada\n");
			            Console.ResetColor();
			         
			            double R1;
			            double Radiciação;
			         
			            Console.Write("Digite o radicando: ");
			            R1 = Convert.ToDouble(Console.ReadLine());
			         
			            Radiciação = Math.Sqrt(R1);
			         
			            Console.WriteLine();
			            Console.WriteLine($"Resultado = {Radiciação}");
			            Console.WriteLine();
			            break;
			         
			        case "L":
			            Console.Clear();
			            Console.ForegroundColor = ConsoleColor.Green;
			            Console.WriteLine("Limpeza efetuada!");
			            Console.ResetColor();
			            Console.WriteLine();
			         
			            break;
			         
			        case "A":
			            Console.ForegroundColor = ConsoleColor.Yellow;
			            Console.WriteLine("Comandos");
			            Console.ResetColor();
			            Console.WriteLine();
			         
			            Console.WriteLine("S abre a função de soma.");
			            Console.WriteLine("E abre a função de subtração.");
			            Console.WriteLine("M abre a função de multiplicação.");
			            Console.WriteLine("D abre a função de divisão.");
			            Console.WriteLine("P abre a função de potenciação.");
			            Console.WriteLine("R abre a função de radiciação (somente raiz quadrada).");
			            Console.WriteLine("I abre o menu novamente.");
			            Console.WriteLine("L limpa a tela.");
			            Console.WriteLine("A abre este menu de ajuda.");
			            Console.WriteLine("X fecha o programa.");
			            Console.WriteLine();
			            
			            Console.ForegroundColor = ConsoleColor.Yellow;
			            Console.WriteLine("Observação: ao efetuar cálculos, use somente números.");
			            Console.ResetColor();
			            Console.WriteLine();
			            
			            break;
			         
			        case "X":
			            Environment.Exit(-1);
			            break;
			         
			        default:
			            Console.ForegroundColor = ConsoleColor.Red;
			            Console.WriteLine("Opção inválida");
			            Console.ResetColor();
			            Console.WriteLine();
			            break;
			            
			        case "I":
			            Console.ForegroundColor = ConsoleColor.Yellow;
			            Console.WriteLine("---Calculadora básica---");
			            Console.WriteLine();
			
			            Console.ForegroundColor = ConsoleColor.Green;
			            Console.WriteLine("--| Menu |--");
			            Console.WriteLine("------------");
			            Console.WriteLine();
			
			            Console.ResetColor();
			
			            Console.WriteLine("[S]. Soma");
			            Console.WriteLine("[E]. Subtração");
			            Console.WriteLine("[M]. Multiplicação");
			            Console.WriteLine("[D]. Divisão");
			            Console.WriteLine("[P]. Exponenciação");
			            Console.WriteLine("[R]. Radiciação");
			            Console.WriteLine("[I]. Menu Inicial");
			            Console.WriteLine("[L]. Limpar");
			            Console.WriteLine("[A]. Ajuda");
			            Console.WriteLine("[X]. Sair");
			            Console.WriteLine();
			            
			            break;
			   }
			}
			while (opcao != "X");
        }
    }   
}