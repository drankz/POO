using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nomee o aluno: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Diite a matrícula desse aluno: ");
            int matricula = int.Parse(Console.ReadLine());

            Random r = new Random();

            double[] notas = new double[50];

            for (int i = 0; i < 50; i++)
            {
                notas[i] = r.Next(1, 10);
            }

            Aluno aluno = new Aluno(nome, matricula, notas);

            Console.WriteLine($"O {aluno.Nome}, matrícula: {aluno.Matricula}, média: {aluno.Media()}");

            Console.ReadLine();
        }
    }

    class Aluno
    {
        private string nome;
        private int matricula;
        private double[] notas;
        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public double[] Notas
        {
            get { return notas; }
            set { notas = value; }
        }

        public Aluno (string nome, int matricula, double[] notas)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.notas = notas;
        }

        public double Media()
        {
            double total = 0.0;

            for (int i = 0; i < notas.Length; i++)
            {
                total += notas[i];
            }

            return total / notas.Length;
        }
    }
}
