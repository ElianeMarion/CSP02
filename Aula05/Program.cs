namespace Aula05
{
    internal class Program
    {
		//Variáveis globais
		public static double n1, n2;

		//Procedimento / função sem retorno: Um sub-algoritmo em que não há retorno, o problema é
		// resolvido no próprio procedimento
		//Assinatura: public static void nomeProcedimento(){ //bloco_Programa }
        public static void Menu()
        {
			//Responsabilidade é exibir o menu
			Console.WriteLine("Digite:\n1 - Entrada de dados\n2 - Soma\n3 - Subtração\n" +
					"4 - Multiplicação\n5 - Divisão\n6 - Conversão ºC para ºF" +
					"\n7 Conversao2\n0 - Sair");
		}

        public static void ExibirResultado(double resultado)
        {
			Console.WriteLine($"O resultado é {resultado}");
		}

		public static void ExibirResultado(double resultado, string operacao)
		{
			Console.WriteLine($"O resultado da {operacao} é {resultado}");
		}

		//Função: Um sub-algoritmo em que há retorno de dado, o problema é resolvido e 
		//um "resultado" é devolvida para quem chamar a função
		//Sintaxe: public static TIPO_RETORNO nomeFuncao(){}
		//TIPO_RETORNO: INT, DOUBLE, BOOL, INT[], STRING, STRING[,]
		public static double Somar()
        {
            double n1, n2;
			Console.WriteLine("Digite primeiro número");
			n1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite segundo número");
			n2 = Convert.ToDouble(Console.ReadLine());
            //double  result = n1 + n2;
            return n1 + n2;
		}
        //                                 10           5
        public static double Somar(double num1, double num2)
        {
            return num1 + num2;
        }

		public static double Dividir(double num1, double num2)
		{
			if (num2 > 0)
			{
				return num1 / num2;
			}
			return 0;

		}
		public static void DividirSemRetorno(double num1, double num2)
		{
			if (num2 > 0)
			{
				ExibirResultado(num1 / num2, "divisão");
			}
			else
			{
				Console.WriteLine("Não é possível dividir por zero!");
			}

		}

		public static void EntradaDeDados()
		{
			Console.WriteLine("Digite primeiro número");
			n1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite segundo número");
			n2 = Convert.ToDouble(Console.ReadLine());
		}

		/*
		 * Elabore uma função chamada Conversao() que deverá solicitar a digitação de uma
		 * temperatura em graus Celsius (ºC) e exiba a temperatura convertida em graus
		 * Fahrenheit (ºF). A fórmula é:  F = (9 x C + 160) / 5
		 */
		public static double Conversao()
		{
			Console.WriteLine("Digite a temperatura em ºC: ");
			double TC = Convert.ToDouble(Console.ReadLine());
			return (9 * TC + 160) / 5 ;
		}

		public static double Conversao(double TC)
		{
			return (9 * TC + 160) / 5;
		}

		static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");
            double resultado;
			n1 = 0;
			n2 = 0;

			int op;
            do
            {
                Menu();
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 0: Console.WriteLine("Obrigada por utilizar nossa calculadora"); break;
                    case 1: 
						EntradaDeDados();
                        break;
					case 2:
                        resultado = Somar(n1,n2); //Somar(10,5);
                        ExibirResultado(resultado);
						//resultado = n1 + n2;
						//Console.WriteLine($"O resultado da adição é {resultado}");
						break;
					case 3:
						resultado = n1 - n2;
						ExibirResultado(resultado, "subtração");

						break;
					case 4:
						resultado = n1 * n2;
						ExibirResultado(resultado, "multiplicação");
						break;
					case 5:
						DividirSemRetorno(n1, n2);
						break;
					case 6:
						Console.WriteLine($"A temperatura informada em ºF é {Conversao()}");
						break;
					case 7:
						Console.WriteLine("Digite a temperatura em ºC: ");
						double TC = Convert.ToDouble(Console.ReadLine());
						Console.WriteLine($"A temperatura de {TC}ºC convertida em ºF é {Conversao(TC)}");
						break;
					default:
						
						Console.WriteLine("Opção inválida");
						break;
				}
            } while (op != 0);
        }
    }
}
