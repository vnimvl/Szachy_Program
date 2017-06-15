using ProgramSzachy.Szachy;
using ProgramSzachy.Szachy.Figura;
using ProgramSzachy.Szachy.Plansza;
using System;
using ProgramSzachy.Szachy.Wlasciwosci.Extensions;
using ProgramSzachy.Szachy.Figura;
using ProgramSzachy.Szachy.Figura.Enums;

namespace ProgramSzachy

{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Szachownica");


            Plansza board = Plansza.Instance;  // Wywoływanie Planszy


            Figure p = FigureFactory.CreateFigure(FigureType.Wieza, Colors.Czarny, new Pozycja('B', 2)); // Zastosowanie Metody Fugite factory.Nazwa(Właściwosci wczesniej nadane)
            board[p, new Pozycja('D', 2)] = p.ShortName();

            Figure q = FigureFactory.CreateFigure(FigureType.Krolowa, Colors.Biały);
            board[q, new Pozycja('A', 7)] = q.ShortName();

            board.PrintBoard();


            Console.WriteLine("Figury na planszy:");
            foreach (string s in board)
            {
                Console.WriteLine(s);
            }

            int figuresOnBoard = board.FigureCount();
            Console.WriteLine("Liczba figur na planszy " + figuresOnBoard);

            





            Console.ReadKey();
        }
    }
}
