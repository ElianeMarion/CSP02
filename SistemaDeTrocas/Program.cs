namespace SistemaDeTrocas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************\n" +
                "Registro de usuário\n" +
				"******************************\n");
            string nome, telefone, email, senha, apelido;
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
		}
    }
}
