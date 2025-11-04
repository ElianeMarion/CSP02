using System.Runtime.Serialization;

namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
			string[] alunos = { "Anderson", "William", "Roberto", "Pedro", "Matheus", "Gabriela", "Joao", "Rafael", "Gabriela" };

			foreach (string nome in alunos)
			{
				Console.WriteLine(nome);
			}

			Console.WriteLine("==================================");
			//Exibir uma lista de alunos
			for (int i = 0; i < alunos.Length; i++)
			{
				Console.WriteLine(alunos[i]);
			}

			int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			foreach (int num in numeros)
			{
				Console.WriteLine(num);
			}
			/*
			 Ler uma matriz de 2x2 e exibir a soma dos elementos da matriz.
			 */
			/*
			int[,] numeros = new int[2, 2];
			int soma = 0; 
			for(int linha = 0; linha < 2; linha++)
			{
				for(int col = 0; col < 2; col++)
				{
					Console.WriteLine($"Digite o valor para a posição {linha}, {col} da matriz");
					numeros[linha, col] = Convert.ToInt32(Console.ReadLine());
					soma += numeros[linha, col];
				}
			}
			Console.WriteLine("Soma = " + soma);

			/*
			 * Elabore um programa que leia uma matriz 4x4. 
			 * Apresente a soma de todos os elementos da linha 1, 
			 * exiba a média de todos os elementos da linha 2;
			 * multiplique cada elemento da linha 3 com o de mesma coluna na linha 4.*/

			/*int[,] matriz = new int[4, 4];
			//Lendo a matriz 4x4
			for (int linha = 0; linha < 4; linha++)
			{
				for (int col = 0; col < 4; col++)
				{
					Console.WriteLine($"Digite o valor para a posição {linha}, {col} da matriz");
					matriz[linha, col] = Convert.ToInt32(Console.ReadLine());			
				}
			}
			soma = 0;
			int somaLinha2 = 0, mult = 0;
			for (int col = 0; col < 4; col++)
			{
				//Somar os elementos da linha1
				soma += matriz[0, col];
				//Somar os elementos da linha2
				somaLinha2 += matriz[1, col];
				//Multiplicar os elementos da linha 3 com os da linha 4
				mult = matriz[2,col] * matriz[3, col];
				Console.WriteLine($"{matriz[2, col]} x {matriz[3, col]} = {mult} ");
			}
			Console.WriteLine("A soma dos elementos da linha 1 = " + soma);
			int media = somaLinha2 / 4;
			Console.WriteLine("A média dos elementos da linha 2 = " + media);


			/*
				//Matriz bidimensional
				int[,] matriz = new int[3, 2]; //matriz é um conjunto de 6 (3x2) elementos inteiros
				int pares = 0;
				for(int linha = 0; linha < 3; linha++)
				{
					for (int coluna = 0; coluna < 2; coluna++)
					{
						Console.WriteLine($"Digite o valor para a posição {linha}, {coluna} da matriz");
						matriz[linha, coluna] = Convert.ToInt32(Console.ReadLine());
					}	
				}
				for (int linha = 0; linha < 3; linha++)
				{
					for (int coluna = 0; coluna < 2; coluna++)
					{
						if (matriz[linha, coluna] % 2 == 0)
						{
							pares++;
						}
					}
				}
				Console.WriteLine("A quantidade de pares é {0}", pares.ToString());

				int[,] numeros =  { { 1, 1}, { 2, 1 }, { 2, 3 }, { 3, 2 } };

				/*string[] alunos = { "Anderson", "William", "Roberto", "Pedro", "Matheus", "Gabriela", "Joao", "Rafael", "Gabriela" };

				//Exibir uma lista de alunos
				for(int i = 0; i < alunos.Length; i++)
				{
					Console.WriteLine(alunos[i]);
				}
				Console.WriteLine("------------------------------------\n" +
					"Aplicar reverse - inverter a ordem");
				Array.Reverse(alunos);
				for (int i = 0; i < alunos.Length; i++)
				{
					Console.WriteLine(alunos[i]);
				}

				Console.WriteLine("------------------------------------\n" +
					"Aplicar sort - ordeno o vetor");
				Array.Sort(alunos);
				for (int i = 0; i < alunos.Length; i++)
				{
					Console.WriteLine(alunos[i]);
				}
				int indice = Array.IndexOf(alunos, "Gabriela");
				Console.WriteLine(indice);
				/*
				 * Ler um vetor com 6 posições, criar um segundo vetor de mesmo tamanho e tipo
				 * sendo a ordem inversa do primeiro vetor
				 * 
				 * A = { 1 ,2, 3, 4, 5, 6}
				 * B = { 6, 5, 4, 3, 2, 1}
				 */
			/*
			int[] vetA = new int[6];
			int[] vetB = new int[6];
			int i;
			for (i = 0; i < vetA.Length; i++)
			{
				Console.WriteLine($"Digite o valor do {i + 1} elemento do vetor: ");
				vetA[i] = Convert.ToInt16(Console.ReadLine());
			}

			/*int x = 5; //vetA.Length - 1
			for (i = 0; i < vetA.Length; i++)
			{
				vetB[x] = vetA[i];
				x--;
			}

			for (i = 0; i < vetA.Length; i++)
			{
				vetB[5-i] = vetA[i];
			}

			for (i = 0; i < vetA.Length; i++)
			{
				Console.WriteLine($"Vetor A[{i}] = {vetA[i]} - Vetor B[{i}] = {vetB[i]}");
			}
			*/
			/*
			 Uma empresa possui 5 vendedores. Vamos elaborar um programa que leia as vendas
			de cada um dos 5 vendedores e exiba total vendido por eles. Vamos utilizar um 
			vetor para armazenar os valores vendidos
			 */
			/*
			double[] valores = new double[5];
			double total = 0;
			//Tamanho do vetor => nomeVetor.Length
			for(int i = 0; i < valores.Length; i++)
			{
				Console.WriteLine($"Digite o valor das vendas do {i + 1}º vendedor: R$");
				valores[i] = Convert.ToDouble( Console.ReadLine() );
				total += valores[i];
			}
			Console.WriteLine("Total das vendas: R$ {0}", total.ToString("0.00"));

			Console.WriteLine("Estrutura de dados homogênea - Vetores");
			//todos os elementos do vetor possuem o mesmo tipo

			//Declaração de um vetor
			int[] idades = new int[5]; //idades é um conjunto de 5 valores inteiros
			int[] numeros = { 10, 20, 30, 40 };
			string[] nomes = new string[5];

			//Atribuição
			idades[0] = 47;
			Console.WriteLine("A idade do primeiro aluno é " + idades[0]);

			int qtdAluno = 5;
			int soma = 0;
			for (int i = 0; i < qtdAluno; i++)
			{
				Console.WriteLine("Informe a idade do aluno: ");
				idades[i] = Convert.ToInt32(Console.ReadLine());
				soma += idades[i];
			}
			Console.WriteLine("A idade do primeiro aluno é " + idades[0]);

			for(int i = 0;i < qtdAluno; i++)
			{
				Console.WriteLine($"A idade do aluno {(i+1)} é {idades[i]}");
			}
			*/
		}
	}
}
