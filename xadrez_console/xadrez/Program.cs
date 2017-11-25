using System;
using System.Collections.Generic;
using tabuleiro;
namespace xadrez
{

	public class Program
{
	public static void Main(string[] args)
	{
            /* Tabuleiro tab = new Tabuleiro(8,8);

             tab.ColocarPosicao(new Torre (tab, Cor.Preto), new Posicao(0,0));
             tab.ColocarPosicao(new Torre(tab, Cor.Preto), new Posicao(1,3));
             tab.ColocarPosicao(new Rei(tab, Cor.Preto), new Posicao(0,0));
             Tela.imprimiTabuleiro(tab);*/
             PosicaoXadrez pos = new PosicaoXadrez('a',1);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
		    Console.ReadKey();
	 }

	}
}