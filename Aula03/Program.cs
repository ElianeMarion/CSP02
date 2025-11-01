namespace Aula03
{
    internal class Program
    {
        static void Main(string[] args)
        {
			//Estrutura de repetição - laços contados

			//Usando o for: Dado um número exibir o fatorial dele
			//4! = 4x3x2x1 = 24
			//5! = 5x4x3x2x1 = 120
			int num, fat = 1;
			Console.WriteLine("Digite um número: ");
			num = Convert.ToInt32(Console.ReadLine());

			for (int i = num; i > 1; i--)
			{
				fat *= i;
			}
			Console.WriteLine($"{num}! =  {fat}");
			//for(inicialização; condição; incremento/decremento)
			//para i de 0 até 5 com incremento de 1 faça
			/*
			 * int numero, soma=0;
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine("Digite um valor: ");
				numero = Convert.ToInt32(Console.ReadLine());
				soma += numero;
			}
			Console.WriteLine("Soma = " + soma);

			for (int i = 10; i > 0; i--)
			{
				Console.WriteLine(i);
			}
			*/
			/*int i;
			Console.WriteLine("Numeros pares");
			for(i = 0; i <= 10; i+=2)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine(i);
			*/
			/*
			//Exibir os números múltiplos de 3 de 1 até 30
			int n = 3;
			string cont;
			do
			{
				n = 3;
				while (n <= 30)
				{
					//if(n % 3 == 0)
					Console.WriteLine(n);
					n += 3;
				}
				Console.WriteLine("Deseja visualizar novamente? (S/N): ");
				cont = Console.ReadLine();
			} while (cont.Equals("S") || cont.Equals("Sim"));
			//1 - saque | 2 - deposito | 3 - Saldo | 4 - sair
			int opcao;
			double valor, saldo = 0;
			do
			{
				Console.Clear();
				Console.WriteLine("Bem vindo ao Banco Alun");
				Console.WriteLine("--------------------------");
				Console.WriteLine("Operações disponíveis: \n1 - Saque" +
					"\t\t2 - Depósito\n3 - Consultar saldo\t4 - Sair");
				opcao = Convert.ToInt32(Console.ReadLine());
				switch (opcao)
				{
					case 1:
						Console.WriteLine("Saque\n-----------------------");
						Console.WriteLine("Digite o valor a ser sacado: R$");
						valor = Convert.ToDouble(Console.ReadLine());
						saldo -= valor;
						break;
					case 2:
						Console.WriteLine("Depósito\n-----------------------");
						Console.WriteLine("Digite o valor a ser depositado: R$");
						valor = Convert.ToDouble(Console.ReadLine());
						saldo += valor;
						break;
					case 3:
						Console.WriteLine("Saldo\n-----------------------");
						Console.WriteLine($"Saldo atual R${saldo}");

						break;
					case 4:
						Console.WriteLine("Obrigada por utilizar nosso sistema");
						break;
					default: Console.WriteLine("Opção inválida"); break;
				}
				Thread.Sleep(2000);
			} while (opcao != 4);
			*/
			//Uma sala com 5 alunos, calcular média de idade da turma
			//double idade, soma = 0;
			//int numeroAluno = 0; //Com qual valor a variavel da condição será inicializado
			//Estrutura de repetição - laços condicionais (while)

			//while(condição) -> enquanto essa condição for verdadeira, o bloco será repetido
			//quando a condição for falsa o programa segue o fluxo, saindo do laço.
			/*
			 Console.WriteLine("Digite a quantidade de alunos da turma: ");
			 int qtdAlunos = Convert.ToInt32(Console.ReadLine());
			 while (numeroAluno <= qtdAlunos)//2. Condição
			 {
				 Console.WriteLine("Digite a idade do " + numeroAluno + "º aluno: ");
				 idade = Convert.ToDouble(Console.ReadLine());
				 soma += idade;
				 numeroAluno++; //Alterar o valor da variável da condição
			 }


			 double media = soma / 5; //Média
			 Console.WriteLine("A média de idade da turma é "  + media);


			 //pares de 0 a 10
			 int n = 1;
			 while (n <= 10)
			 {
				 Console.WriteLine(n);
				 n+=2; //n = n + 2;

			 }
			

			//Estrutura de repetição - do..while
			/*
			 do{


			}while(condição);
			 */
			/*
			Console.WriteLine("Digite a quantidade de alunos da turma: ");
		    int qtdAlunos = Convert.ToInt32(Console.ReadLine());
			int numeroAluno=0;
			do{
				Console.WriteLine("Digite a idade do " + numeroAluno + "º aluno: ");
				idade = Convert.ToDouble(Console.ReadLine());
				soma += idade;
				numeroAluno++; //Alterar o valor da variável da condição
			} while (numeroAluno <= qtdAlunos) ;//2. Condição


			double media = soma / 5; //Média
			Console.WriteLine("A média de idade da turma é " + media);
			*/
		}
	}
}
