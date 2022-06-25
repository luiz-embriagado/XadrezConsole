using System;
using tabuleiro;
using tabuleiro.Enums;
using tabuleiro.Exceptions;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args) {

            try {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 99));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));


                Tela.imprimitTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
            }
    }


}