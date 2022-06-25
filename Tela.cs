using System;
using tabuleiro;

namespace xadrez_console
{
    internal class Tela
    {
        public static void imprimitTabuleiro(Tabuleiro tab) {
            for (int i=0; i< tab.linha; i++)
            {
                for (int j=0; j< tab.colunas; j++)
                {
                    if (tab.Peca(i, j) == null) {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.Peca(i, j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
