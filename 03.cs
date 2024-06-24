using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp312
{
    internal class Program
    {
        public class Peao
        {
            public string Cor { get; private set; }
            public int Identificador { get; private set; }
            public int Posicao { get; private set; }
            
            private const int NumeroDeCasas = 100;

            public Peao(string cor, int identificador)
            {
                Cor = cor;
                Identificador = identificador;
                Posicao = 0;
            }

            public void Mover(int numeroDeCasas)
            {
                if (Posicao + numeroDeCasas <= NumeroDeCasas)
                {
                    Posicao += numeroDeCasas;
                }
                
                else
                {
                    Posicao = NumeroDeCasas;
                }
                
                Console.WriteLine($"Peão {Identificador} da cor {Cor} movido para a posição {Posicao}.");
            }

            public void RetornarCasa()
            {
                Posicao = 0;
                Console.WriteLine($"Peão {Identificador} da cor {Cor} retornou para a posição inicial.");
            }

            public static void Main(string[] args)
            {
                Peao peao1 = new Peao("Vermelho", 1);
                Peao peao2 = new Peao("Azul", 2);

                peao1.Mover(5);
                peao1.Mover(10);
                peao2.Mover(3);

                peao1.RetornarCasa();

                peao1.Mover(50);
                peao2.Mover(30);

                Console.WriteLine("Pressione Enter para sair...");
                
                Console.ReadLine();
            }
        }
    }
}
