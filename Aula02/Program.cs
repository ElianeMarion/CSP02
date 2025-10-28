namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estrutura de decisão");
			//Condição é uma comparação em que o resultado será lógico (V ou F)
			//Operador relacional: > < >= <= == !=

			//Será um aplicado um desconto de 10% compras valor acima de R$ 200,00
			/*Console.WriteLine("Informe o valor da compra: ");
			double valor = Convert.ToDouble(Console.ReadLine());
			if (valor > 200)
			{
				double desconto = valor * 0.10;
				valor -= desconto; //valor = valor - desconto;
				//valor -= valor * 0.10;
			}
			Console.WriteLine("Valor final: " + valor);
			*/
			//Decisão completa
			//Informar se uma pessoa pode votar
			//idade >= 16 pode votar | idade < 16  não pode votar
			/*
			Console.WriteLine("Digite sua idade: ");
			int idade = Convert.ToInt32(Console.ReadLine());

			if (idade >= 16) //Parte verdadeira da condição
			{
				Console.WriteLine("Pode votar");
				Console.WriteLine("Vote consciente");
			}
			else //Parte falsa da condição
			{
				Console.WriteLine("Não pode votar");
				Console.WriteLine("Tenha paciência");
			}
			*/
			/*
             Exercício: Você foi contratado para desenvolver um programa para uma ONG chamada 
            “Solidariedade Sem Fronteiras”.
            A ONG tem como objetivo ajudar comunidade carente do bairro em que estão inseridos.
            O estatuto da ONG determina que todas as doações recebidas devem gerar um valor para
            investimento, para cobrir momentos de necessidade. 
            O valor do investimento deve ser de 5% da doação. Porém, em casos em que as doações
            ultrapassem R$1000,00 o investimento deve ser de 10% da doação. 
            Sua missão é criar um programa capaz de fazer os cálculos necessários e indicar
            quanto deve ser investido.
             */
			/*
			double doacao, investimento;
			//entrada: Valor da doação
			Console.WriteLine("Digite o valor da doação");
			doacao = Convert.ToDouble(Console.ReadLine());
			if (doacao > 1000)
			{
				investimento = doacao * 0.10;
			}
			else
			{
				investimento = doacao * 0.05;
			}
			//Saída: Valor do investimento
			Console.WriteLine("O valor do investimento será R$ " + investimento);
			*/

			//O aluno será aprovado se a média for >=6, <3 retido, media entre 3 e 6 
			//o aluno terá direito a fazer exame, calcular uma nova média
			/*
			double nota1, nota2, media;
			Console.WriteLine("Informe a primeira nota do aluno: ");
			nota1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Informe a segunda nota do aluno: ");
			nota2  = Convert.ToDouble(Console.ReadLine());
			media = (nota1 + nota2)/2;
			if(media >= 6)
			{
				Console.WriteLine("Aluno aprovado com média " + media);
			}
			else if(media < 3)
			{
				Console.WriteLine("Aluno reprovado com média " + media);
			}
			else
			{
				Console.WriteLine("Aluno deverá fazer exame, média " + media);
				Console.WriteLine("Informe a nota do exame: ");
				double exame = Convert.ToDouble(Console.ReadLine());
				double novaMedia = (exame + media)/ 2;
				if (novaMedia >= 6)
				{
					Console.WriteLine("Aluno aprovado após exame com média " + novaMedia);
				}
				else
				{
					Console.WriteLine("Aluno reprovado após exame com média " + novaMedia);
				}
			}
			*/
			//O aluno será aprovado se a média for >=6, <3 retido, media entre 3 e 6 
			//o aluno terá direito a fazer exame, calcular uma nova média
			/*
			double nota1, nota2, media;
			Console.WriteLine("Informe a primeira nota do aluno: ");
			nota1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Informe a segunda nota do aluno: ");
			nota2 = Convert.ToDouble(Console.ReadLine());
			media = (nota1 + nota2) / 2;
			Console.WriteLine("Informe a frequência do aluno: ");
			double frequencia = Convert.ToDouble(Console.ReadLine());
			if (media >= 6 && frequencia >= 75) { 

					Console.WriteLine("Aluno aprovado com média " + media);
				}
			
			else 
				{
					Console.WriteLine("Aluno reprovado com média " + media);
				}
				*/
			// não !
			// e   &&
			// ou  ||

			//usuario = admin | senha = admin123
			Console.WriteLine("Login");
			Console.WriteLine("Digite seu usuário: ");
			string usuario = Console.ReadLine();
			Console.WriteLine("Digite sua senha: ");
			string senha = Console.ReadLine();
			if ((usuario.Equals("admin") || usuario.Equals("Admin")) && senha.Equals("admin123"))
			{
				Console.WriteLine("Bem vindo ao sistema!");
			}
			else
			{
				Console.WriteLine("Usuário e/ou senha incorretos");
			}

		}
	}
}
