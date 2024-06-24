using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp319
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
            Console.WriteLine("Cadastro de Clientes\n");

            Cliente[] clientes = new Cliente[50];
            int contadorClientes = 0;

            while (true)
            {
                Console.Write("Digite o nome do cliente (ou digite 'sair' para sair): ");
                string nome = Console.ReadLine();

                if (nome.ToLower() == "sair")
                {
                    break;
                } 

                Console.Write("Digite o endereço do cliente: ");
                string endereco = Console.ReadLine();

                Console.Write("Digite o telefone do cliente: ");
                string telefone = Console.ReadLine();

                Cliente cliente = new Cliente(nome, endereco, telefone);

                clientes[contadorClientes] = cliente;
                contadorClientes++;

                Console.WriteLine("\nCliente cadastrado com sucesso.\n");

                if (contadorClientes >= 50)
                {
                    Console.WriteLine("Limite máximo de clientes atingido (50 clientes).");
                    break;
                }
            }

            Console.WriteLine("\nLista de Clientes Cadastrados:\n");

            for (int i = 0; i < contadorClientes; i++)
            {
                Console.WriteLine($"Cliente {i + 1}:");
                clientes[i].ExibirDados();
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
