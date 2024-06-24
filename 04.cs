using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp313
{
    internal class Program
    {
        public class Peao
        {
            public int Posicao { get; set; } = 0;

            public Peao()
            {
                Posicao = 0;
            }
        }

        public class Jogador
        {
            public string Cor { get; set; }
            public int Identificador { get; set; }
            public string Nome { get; set; }
            public Peao[] Peoes { get; set; }

            public Jogador(string cor, int identificador, string nome)
            {
                Cor = cor;
                Identificador = identificador;
                Nome = nome;
                Peoes = new Peao[4];
                for (int i = 0; i < Peoes.Length; i++)
                {
                    Peoes[i] = new Peao();
                }
            }

            public int LancarDado()
            {
                Random random = new Random();
                return random.Next(1, 7);
            }

            public void MoverPeao(int peaoId, int passos)
            {
                if (peaoId < 0 || peaoId >= Peoes.Length)
                {
                    Console.WriteLine("ID do peão inválido.");
                    return;
                }

                Peoes[peaoId].Posicao += passos;
                Console.WriteLine($"Peão {peaoId} do jogador {Nome} movido para a posição {Peoes[peaoId].Posicao}.");
            }

            static void Main(string[] args)
            {
                Jogador jogador1 = new Jogador("Vermelho", 1, "Alice");

                int resultadoDado = jogador1.LancarDado();
                Console.WriteLine($"{jogador1.Nome} lançou o dado e obteve: {resultadoDado}");

                jogador1.MoverPeao(0, resultadoDado);

                resultadoDado = jogador1.LancarDado();
                Console.WriteLine($"{jogador1.Nome} lançou o dado e obteve: {resultadoDado}");
                jogador1.MoverPeao(1, resultadoDado);

                Console.ReadLine();
            }
        }
    }
}
