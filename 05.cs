using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp315
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tabuleiro = new Tabuleiro();

            while (!TodosPassaramDeDezCasas(tabuleiro))
            {
                Console.WriteLine("Escolha um peão para mover:");
                Console.WriteLine();

                int resultadoDado = tabuleiro.LancarDado();

                Console.WriteLine($"O peão irá mover {resultadoDado} casas.");

                MostrarPosicoes(tabuleiro);

                Console.WriteLine("Escolha um peão para mover:");
                int peaoEscolhido = int.Parse(Console.ReadLine());

                tabuleiro.VerificarCaptura(peaoEscolhido - 1);
                tabuleiro.VerificarCasaSegura(peaoEscolhido - 1);

                tabuleiro.MoverPeao(peaoEscolhido - 1, resultadoDado);

                Console.WriteLine($"O peão {peaoEscolhido} está agora na casa {tabuleiro.Peoes[peaoEscolhido - 1]}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static bool TodosPassaramDeDezCasas(Tabuleiro tabuleiro)
        {
            foreach (var posicao in tabuleiro.Peoes)
            {
                if (posicao < 10)
                {
                    return false;
                } 
            }
            
            return true;
        }

        static void MostrarPosicoes(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Peoes.Length; i++)
            {
                Console.WriteLine($"Peão {i + 1} : {tabuleiro.Peoes[i]}");
            }
        }
    }

    class Tabuleiro
    {
        public int[] Peoes;
        public int[] Casas;

        public Tabuleiro()
        {
            Peoes = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Peoes[i] = 0;
            }

            Casas = new int[50];
            for (int i = 10; i < 50; i += 10)
            {
                Casas[i] = 51;
            }
        }

        public void VerificarCasaSegura(int i)
        {
            int posicao = Peoes[i];
            
            if (Casas[posicao] == 51)
            {
                Console.WriteLine($"Peão {i + 1} está em uma casa segura.");
            }
        }

        public void VerificarCaptura(int i)
        {
            int posicao = Peoes[i];
            
            if (Casas[posicao] != 51 && Casas[posicao] != 0)
            {
                int peaoCapturado = Casas[posicao] - 1;
                
                if (peaoCapturado != i)
                {
                    Peoes[peaoCapturado] = 0;
                    Console.WriteLine($"Peão {peaoCapturado + 1} foi capturado e voltou para a casa 0.");
                }
            }
            
            Casas[posicao] = i + 1;
        }

        public int LancarDado()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        public void MoverPeao(int i, int m)
        {
            Peoes[i] += m;
        }
    }
}
