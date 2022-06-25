using System;
using tabuleiro;
namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args) {


            Tabuleiro tab = new Tabuleiro(4, 2);

            Tela.imprimitTabuleiro(tab);

            Console.ReadLine();
        }
    }


}