namespace SistemaDeTrocas
{
    internal class Program
    {
		//Variáveis globais
		public static string email, senha, apelido;
		public static double[] precoProdutos = new double[10];
		public static List<string> produtos = new List<string>();

		/*
			 Sistema de doação
             1 – Registrar um novo usuário (nome, email, senha, apelido)
             2 – Login (solitar usuario(email) e a senha (se estiverem corretos vamos mandar msg
            Bem vindo ao sistema de doação nome, senão usuário/senha inválido
             3 – Sair (Obrigada(o) por utilizar nosso sistema!
             */

		public static void Menu() {
			Console.WriteLine("SISTEMA DE TROCAS\n");
			Console.WriteLine("1 - Registrar um novo usuário\n" +
				"2 - Logar\n" +
				"3 - Sair\n");
		}
		public static void SubMenu()
		{
			Console.Clear();
			Console.WriteLine("\nDigite 1 para registrar um produto");
			Console.WriteLine("Digite 2 para mostrar os produtos");
			Console.WriteLine("Digite 3 Somar valores dos produtos");
			Console.WriteLine("Digite 4 para exibir a média de um produto");
			Console.WriteLine("Digite 0 para voltar para o menu principal");

		}

		public static double SomarValorCarrinho(double[] valores)
		{
			double soma = 0;
			for (int i = 0; i < valores.Length; i++)
			{
				soma += valores[i];
			}
			return soma;
		}

		public static double SomarValorCarrinhoForeach(double[] valores)
		{
			double soma = 0;
			foreach (double valor in valores)
			{
				soma += valor;
			}
			return soma;
		}
		public static void RegistrarUsuario()
		{
			Console.WriteLine("******************************\n" +
				"Registro de usuário\n" +
				"******************************\n");
			Console.WriteLine("Digite o nome do usuário que deseja registrar: ");
			string nome = Console.ReadLine();
			Console.WriteLine("Digite o telefone do usuário: ");
			string telefone = Console.ReadLine();
			Console.WriteLine("Digite o e-mail do usuário: ");
			email = Console.ReadLine();
			Console.WriteLine("Digite a senha do usuário: ");
			senha = Console.ReadLine();
			Console.WriteLine("Digite o apelido do usuário: ");
			apelido = Console.ReadLine();
			Console.WriteLine("Usuário " + nome + " foi registrado com sucesso!");
		}

		public static void RegistrarProduto()
		{
			Console.Clear();
			Console.WriteLine("Registro de Produto");
			if (produtos.Count < 10)
			{
				Console.WriteLine("Digite o nome do produto");
				string nomeProduto = Console.ReadLine();
				produtos.Add(nomeProduto); //Inserção de items na lista
				Console.WriteLine("Digite o preço do produto");
				precoProdutos[produtos.Count - 1] = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine($"O produto {nomeProduto} foi cadastrado com sucesso!");
			}
			else
			{
				Console.WriteLine("Infelizmente não é possível realizar o cadastro, contate o suporte");
			}
		}

		public static List<string> testesLista()
		{
			produtos.Add("Mouse");
			produtos.Add("Teclado");
			produtos.Add("Calculadora");
			Console.WriteLine(produtos.Contains("Teclado"));
			produtos.RemoveAt(2);
			produtos.Sort();
			return produtos;
			
		}

		public static void ExibirProdutos()
		{

			Console.Clear();
			Console.WriteLine("Listando os produtos cadastrados");
			//                      List<string> produtos
			foreach (var produto in produtos)
			{
				Console.WriteLine(produto);
			}
			Thread.Sleep(2000);
		}

		public static string ExibirProdutoEPreco()
		{
			string mensagem = "";
			//Console.Clear();
			Console.WriteLine("Listando os produtos cadastrados");
			for(int i = 0; i < produtos.Count; i++)
			{
				mensagem += produtos[i] + " - R$ " + precoProdutos[i] + "\n";
			}
			return mensagem;

		}
		public static bool ValidarUsuario(string emailUser, string password)
		{
			if(email.Equals(emailUser) && senha.Equals(password) ) 
				return true;
			
			return false;
		}
		static void Main(string[] args)
        {

			var teste = testesLista();
			foreach (string prod in teste)
			{
				Console.WriteLine(prod);
			}
			string nome, telefone;
			int opcao;
			do
			{

				Menu();
				opcao = Convert.ToInt32(Console.ReadLine());
				switch (opcao)
				{
					case 1:
						RegistrarUsuario();
						break;
					case 2:
						
						Console.WriteLine("******************************\n" +
						"Login\n" +
						"******************************\n");
						Console.WriteLine("Digite seu email: ");
						string emailParaLogin = Console.ReadLine();
						Console.WriteLine("Digite sua senha: ");
						string senhaParaLogin = Console.ReadLine();
						if (ValidarUsuario(emailParaLogin, senhaParaLogin))
						{
							int opcaoSubMenu;
							Console.WriteLine("Bem vindo ao sistema " + apelido);
							do
							{
								SubMenu();
								opcaoSubMenu = Convert.ToInt32(Console.ReadLine());
								switch (opcaoSubMenu) { 
									case 1: RegistrarProduto();break;
									case 2: ExibirProdutos();
										
										Console.WriteLine("------------------------------\n");
										Console.WriteLine(ExibirProdutoEPreco());
										Thread.Sleep(2000);
										break;
									case 3: Console.WriteLine("Soma do carrinho é R$ " + SomarValorCarrinho(precoProdutos));break;
							}
							} while (opcaoSubMenu != 0);
						}
						else
							Console.WriteLine("Usuario e/ou senha inválidos");
						break;
					case 3:
						Console.WriteLine("Obrigada(o) por utilizar nosso sistema!"); break;
					default: Console.WriteLine("Opção inválida!"); break;
				}
			} while (opcao != 3);
			
		}
    }
}
