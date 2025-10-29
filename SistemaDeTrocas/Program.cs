namespace SistemaDeTrocas
{
    internal class Program
    {
		/*
			 Sistema de doação
             1 – Registrar um novo usuário (nome, email, senha, apelido)
             2 – Login (solitar usuario(email) e a senha (se estiverem corretos vamos mandar msg
            Bem vindo ao sistema de doação nome, senão usuário/senha inválido
             3 – Sair (Obrigada(o) por utilizar nosso sistema!
             */
		static void Main(string[] args)
        {
			string nome, telefone, email, senha, apelido;

			Console.WriteLine("SISTEMA DE TROCAS\n");
			Console.WriteLine("1 - Registrar um novo usuário\n" +
				"2 - Logar\n" +
				"3 - Sair\n");
			int opcao = Convert.ToInt32(Console.ReadLine());
			switch (opcao)
			{
				case 1:
					Console.WriteLine("******************************\n" +
				"Registro de usuário\n" +
				"******************************\n");
					Console.WriteLine("Digite o nome do usuário que deseja registrar: ");
					nome = Console.ReadLine();
					Console.WriteLine("Digite o telefone do usuário: ");
					telefone = Console.ReadLine();
					Console.WriteLine("Digite o e-mail do usuário: ");
					email = Console.ReadLine();
					Console.WriteLine("Digite a senha do usuário: ");
					senha = Console.ReadLine();
					Console.WriteLine("Digite o apelido do usuário: ");
					apelido = Console.ReadLine();
					Console.WriteLine("Usuário " + nome + " foi registrado com sucesso!");
					break;
				case 2:
					//email cadastrado = "admin@fiap.com" senha cadastrada = "admin123
					Console.WriteLine("******************************\n" +
					"Login\n" +
					"******************************\n");
					Console.WriteLine("Digite seu email: ");
					string emailParaLogin = Console.ReadLine();
					Console.WriteLine("Digite sua senha: ");
					string senhaParaLogin = Console.ReadLine();
					if (emailParaLogin.Equals("admin@fiap.com.br") && senhaParaLogin.Equals("admin123"))
						Console.WriteLine("Bem vindo ao sistema " + emailParaLogin);
					else
						Console.WriteLine("Usuario e/ou senha inválidos");
					break;
				case 3:
					Console.WriteLine("Obrigada(o) por utilizar nosso sistema!"); break;
				default: Console.WriteLine("Opção inválida!"); break;
			}
			
		}
    }
}
