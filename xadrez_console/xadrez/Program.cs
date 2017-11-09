using System;
using System.Collections.Generic;
using tabuleiro;
namespace xadrez
{

	public class Program
{
	public static void Main(string[] args)
	{
            Tabuleiro tab = new Tabuleiro(8,8);
            Tela.imprimiTabuleiro(tab);
		    Console.ReadKey();
	 }

	}
}