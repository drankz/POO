using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp320
{
    public class Funcionario
    {
        private string nome;
        private string cargo;
        private double salario;

        public Funcionario(string nome, string cargo, double salario = 0.0)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario1 = new Funcionario("João Silva", "Analista");

            Funcionario funcionario2 = new Funcionario("Maria Souza", "Gerente", 5000.0);

            Console.WriteLine($"Nome: {funcionario1.Nome}, Cargo: {funcionario1.Cargo}, Salário: {funcionario1.Salario}");
            Console.WriteLine($"Nome: {funcionario2.Nome}, Cargo: {funcionario2.Cargo}, Salário: {funcionario2.Salario}");

            funcionario1.Salario = 3000.0;
            Console.WriteLine($"Novo salário de {funcionario1.Nome}: {funcionario1.Salario}");

            Console.ReadLine();
        }
    }
}
