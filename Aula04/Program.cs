using System.Runtime.Serialization;

namespace Aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int qtdAluno = 5;
			int idade, soma = 0;
			for (int i = 0; i < qtdAluno; i++)
			{
				Console.WriteLine("Informe a idade do aluno: ");
				idade = Convert.ToInt32(Console.ReadLine());
				soma += idade;
			}
		}
    }
}
