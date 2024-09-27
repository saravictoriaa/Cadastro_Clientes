using System;
using System.Collections.Generic;

namespace TDE_POO_SaraV
{
    public class ListaClientes
    {
        private List<Cliente> clientes = new List<Cliente>();

        // Adiciona um novo cliente ao repositório
        public void AdicionarCliente(Cliente cliente)
        {
            clientes.Add(cliente);
            Console.WriteLine("Cliente adicionado com sucesso!");
        }

        // Edita as informações de um cliente existente
        public void EditarCliente(int id, string novoNome, string novoEmail)
        {
            Cliente cliente = clientes.Find(c => c.IdCliente == id);
            if (cliente != null)
            {
                cliente.Nome = novoNome;
                cliente.Email = novoEmail;
                Console.WriteLine("Cliente editado com sucesso!");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }

        // Remove um cliente do repositório
        public void RemoverCliente(int id)
        {
            Cliente cliente = clientes.Find(c => c.IdCliente == id);
            if (cliente != null)
            {
                clientes.Remove(cliente);
                Console.WriteLine("Cliente removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }

        // Lista todos os clientes
        public void ListarClientes()
        {
            foreach (var cliente in clientes)
            {
                cliente.ExibirInformacoes();
            }
        }
    }
}
