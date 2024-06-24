using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp316
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Cliente(string nome, string endereco, string telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Telefone: {Telefone}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cadastro de Cliente\n");

            Console.Write("Digite o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o endereço do cliente: ");
            string endereco = Console.ReadLine();

            Console.Write("Digite o telefone do cliente: ");
            string telefone = Console.ReadLine();

            Cliente cliente = new Cliente(nome, endereco, telefone);

            Console.WriteLine("\nCliente cadastrado com sucesso:\n");

            cliente.ExibirDados();

            Console.ReadLine();
        }
    }
}
