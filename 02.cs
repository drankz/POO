using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp310
{
    public class Triangulo
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public double Lado1 { get { return lado1; } }
        public double Lado2 { get { return lado2; } }
        public double Lado3 { get { return lado3; } }

        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public Triangulo()
        {
            lado1 = 3.0;
            lado2 = 4.0;
            lado3 = 5.0;
        }

        public bool EhValido()
        {
            return lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1;
        }

        public double Perimetro()
        {
            return lado1 + lado2 + lado3;
        }

        public double Area()
        {
            double semiPerimetro = Perimetro() / 2;
            return Math.Sqrt(semiPerimetro * (semiPerimetro - lado1) * (semiPerimetro - lado2) * (semiPerimetro - lado3));
        }

        public void ImprimirLados()
        {
            Console.WriteLine($"Lado 1: {lado1}");
            Console.WriteLine($"Lado 2: {lado2}");
            Console.WriteLine($"Lado 3: {lado3}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t1 = new Triangulo(7.0, 10.0, 5.0);

            Console.WriteLine("Triângulo t1:");
            t1.ImprimirLados();

            Console.WriteLine($"É válido: {t1.EhValido()}");
            Console.WriteLine($"Perímetro: {t1.Perimetro()}");
            Console.WriteLine($"Área: {t1.Area()}");

            Console.WriteLine();

            Triangulo t2 = new Triangulo();

            Console.WriteLine("Triângulo t2:");
            t2.ImprimirLados();

            Console.WriteLine($"É válido: {t2.EhValido()}");
            Console.WriteLine($"Perímetro: {t2.Perimetro()}");
            Console.WriteLine($"Área: {t2.Area()}");

            Console.ReadLine();
        }
    }
}
