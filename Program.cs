using System;
using TDE_POO_SaraV;

class Program
{
    static void Main(string[] args)
    {
        ListaClientes repositorio = new ListaClientes();

        while (true)
        {
            Console.WriteLine("\n1. Adicionar Cliente");
            Console.WriteLine("2. Editar Cliente");
            Console.WriteLine("3. Remover Cliente");
            Console.WriteLine("4. Listar Clientes");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Console.Write("ID do Cliente: ");
                    int id = int.Parse(Console.ReadLine());
                    repositorio.AdicionarCliente(new Cliente(id, nome, email));
                    break;

                case "2":
                    Console.Write("ID do Cliente a ser editado: ");
                    int idEditar = int.Parse(Console.ReadLine());
                    Console.Write("Novo Nome: ");
                    string novoNome = Console.ReadLine();
                    Console.Write("Novo Email: ");
                    string novoEmail = Console.ReadLine();
                    repositorio.EditarCliente(idEditar, novoNome, novoEmail);
                    break;

                case "3":
                    Console.Write("ID do Cliente a ser removido: ");
                    int idRemover = int.Parse(Console.ReadLine());
                    repositorio.RemoverCliente(idRemover);
                    break;

                case "4":
                    repositorio.ListarClientes();
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
