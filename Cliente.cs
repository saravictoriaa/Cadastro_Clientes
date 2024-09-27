using System;

namespace TDE_POO_SaraV
{
    public class Cliente : Pessoa
    {
        public int IdCliente { get; set; }
        public DateTime DataCadastro { get; set; }

        public Cliente(int id, string nome, string email)
        {
            IdCliente = id;
            Nome = nome;
            Email = email;
            DataCadastro = DateTime.Now;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"ID: {IdCliente}, Nome: {Nome}, Email: {Email}, Data de Cadastro: {DataCadastro}");
        }
    }
}
