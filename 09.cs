using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp321
{
    public class Cargo
    {
        private int codigoDoCargo;
        private double valorDaHoraTrabalhada;

        public Cargo(int codigoDoCargo, double valorDaHoraTrabalhada)
        {
            this.codigoDoCargo = codigoDoCargo;
            this.valorDaHoraTrabalhada = valorDaHoraTrabalhada;
        }

        public int Codigo { get { return codigoDoCargo; } set { codigoDoCargo = value; } }
        public double Valor { get { return valorDaHoraTrabalhada; } set { valorDaHoraTrabalhada = value; } }
    }

    public class Funcionario
    {
        private Cargo cargo;
        private char sexo;
        private double quantidadeHorasTrabalhadas;

        public Funcionario(Cargo cargo, char sexo, double quantidadeHorasTrabalhadas)
        {
            this.cargo = cargo;
            this.sexo = sexo;
            this.quantidadeHorasTrabalhadas = quantidadeHorasTrabalhadas;
        }

        public Cargo CargoFuncionario { get { return cargo; } set { cargo = value; } }
        public char Sexo { get { return sexo; } set { sexo = value; } }
        public double QuantidadeHorasTrabalhadas { get { return quantidadeHorasTrabalhadas; } set { quantidadeHorasTrabalhadas = value; } }

        public double CalcularSalarioFinal()
        {
            double salarioFinal = this.CargoFuncionario.Valor * quantidadeHorasTrabalhadas;
            return salarioFinal;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cargo pedreiro = new Cargo(1, 300);
            Cargo pintor = new Cargo(2, 400);
            Cargo empresario = new Cargo(3, 1400);

            Funcionario f1 = new Funcionario(pedreiro, 'M', 12);
            Funcionario f2 = new Funcionario(pintor, 'M', 6);
            Funcionario f3 = new Funcionario(empresario, 'F', 8);

            Console.WriteLine($"Funcionário 1: Pedreiro");
            Console.WriteLine($"Sexo: {f1.Sexo}");
            Console.WriteLine($"Quantidade de horas trabalhadas: {f1.QuantidadeHorasTrabalhadas}");
            Console.WriteLine($"Salário Final: {f1.CalcularSalarioFinal()}");
            Console.WriteLine();

            Console.WriteLine($"Funcionário 2: Pintor");
            Console.WriteLine($"Sexo: {f2.Sexo}");
            Console.WriteLine($"Quantidade de horas trabalhadas: {f2.QuantidadeHorasTrabalhadas}");
            Console.WriteLine($"Salário Final: {f2.CalcularSalarioFinal()}");
            Console.WriteLine();

            Console.WriteLine($"Funcionário 3: Empresário");
            Console.WriteLine($"Sexo: {f3.Sexo}");
            Console.WriteLine($"Quantidade de horas trabalhadas: {f3.QuantidadeHorasTrabalhadas}");
            Console.WriteLine($"Salário Final: {f3.CalcularSalarioFinal()}");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
