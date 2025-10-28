namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada x Processamento x Saída
            //Comando de saída -> Sistema vai interagir com o usuário
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Bem vindos ao curso C#");

            

            /* Variáveis de memória: É um espaço na memória de RAM para armazenar informações
             * tipo nomeVariavel;
             * */


            int idade;
            float salario;
            bool casado;
            char letra;
            string nome; //conjunto de caracteres
            string numero = "25";

            //Atribuição
            idade = 25;
            letra = 'a';
            nome = "Eliane";

			//Comando de entrada -> Usuário interagir com o sistema
			/*
             * Console.WriteLine("Digite seu nome");
             nome = Console.ReadLine();

             Console.WriteLine("Digite sua idade");
             idade = Convert.ToInt16(Console.ReadLine());

             Console.WriteLine(nome + " tem " + idade + " anos.");
            */

			/* Operadores aritméticos
             * +
             * -
             * *
             * /
             * % => Resto da divisão
             * (/ e * ) + -
             * () -> prioriza
             * */

			/* int n1 = 6, n2 = 2;
			 double resultado;
			 resultado = n1 % n2; //Processamento: var = valor / calculo
			 Console.WriteLine(resultado);

			 //Solicitar dois números para o usuário e fazer as 4 operações
			 double a;
			 int b;
			 Console.WriteLine("Digite um número: ");
			 a = Convert.ToDouble(Console.ReadLine());
			 Console.WriteLine("Digite segundo número: ");
			 b = Convert.ToInt32(Console.ReadLine());


			 resultado = a + b;
			 Console.WriteLine("Soma = " + resultado);

			 resultado = a - b;
			 Console.WriteLine("Subtração = " + resultado);

			 resultado = a * b;
			 Console.WriteLine("Multiplicação = " + resultado);

			 resultado = a / b;
			 Console.WriteLine("Divisão = " + resultado);

			 resultado = a % b;
			 Console.WriteLine("Resto da divisão (módulo) = " + resultado);

			 int x = 5;
			 x = x + 2;

			 x += 2; //  +=   -=   *=   /=  %=

			 //var++  => somar 1 na própria variável
			 //var--  => subtrair 1 na própria variável

			 int i = 1;
			 i = i + 1;
			 Console.WriteLine(i);
			 i += 1;
			 Console.WriteLine(i);
			 i++;
			 Console.WriteLine(i);
			*/


			/* Elaborar um programa que exiba a média de um aluno que fez duas provas */
			double nota1, nota2, media;
			Console.WriteLine("Digite a primeira nota: ");
			nota1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite a segunda nota: ");
			nota2 = Convert.ToDouble(Console.ReadLine());
			media = (nota1 + nota2) / 2;
			Console.WriteLine("Média = " + media); //Concatenar => Juntar dois textos
			//Enviar uma mensagem se ele passou de ano (media for maior ou igual a 6)
			//Condição: var OP_REL valor/variavel
			if(media >= 6)
			{
				Console.WriteLine("O aluno foi aprovado!");
			}
				

			/* Considerar que o usuário vai informar 4 dígitos da placa antiga HIO-9876 
			 * você vai exibir o final da placa "
			 * */
			int placa, digito;
			Console.WriteLine("Informe os dígitos da placa");
			placa = Convert.ToInt32(Console.ReadLine());
			digito = placa % 10;
			Console.WriteLine("O dígito final da placa é " + digito);

			/*
				Caixa eletrônico: 50, 20, 10
				Sacar um valor: 180
				Quantidade de notas de R$ 50: 3
				Quantidade de notas de R$ 20: 1
				Quantidade de notas de R$ 10: 1
			*/

			int valor, q50, q20, q10;
			Console.WriteLine("Digite o valor do saque: ");
			valor = Convert.ToInt32(Console.ReadLine());
			q50 = valor / 50; //Divisão inteira
			valor = valor % 50; //Peguei o que faltou para sacar
			q20 = valor / 20; 
			valor = valor % 20;
			q10 = valor / 10;

			Console.WriteLine("Quantidade de notas de R$ 50,00: " + q50);
			Console.WriteLine("Quantidade de notas de R$ 20,00: " + q20);
			Console.WriteLine("Quantidade de notas de R$ 10,00: " + q10);



		}
	}
}
