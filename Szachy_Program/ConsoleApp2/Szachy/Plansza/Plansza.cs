using ProgramSzachy.Szachy;
using ProgramSzachy.Szachy.Wlasciwosci;
using ProgramSzachy.Szachy.Wlasciwosci.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProgramSzachy.Szachy.Plansza
{
    sealed class Plansza : IEnumerable
    {
        #region Fields

        private static readonly Plansza plansza = new Plansza();

        private const int boardSize = Stala.BOARD_SIZE;
        private string fillPattern1 = "[X]", fillPattern2 = "[ ]";
        private string[,] board;

        #endregion

        public static Plansza Instance        // Tworzenie wzorca projektowego do przechowywania szachownicy
        {
            get
            {
                return plansza;
            }
        }

        static Plansza()
        {
        }

        private Plansza()
        {
            board = new string[boardSize, boardSize];
            board.Fill(fillPattern1, fillPattern2, boardSize);
        }

        #region Properties

        public string this[Figure f, Pozycja pos]
        {
            get
            {
                return board[pos.iX, pos.Y];
            }
            set
            {
                f.Pozycja = pos;
                board[pos.iX, pos.Y] = value;
            }
        }

        #endregion

        #region Methods

        public void PrintBoard()
        {
            string temp = string.Empty;
            List<char> letters = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

            for (int i = 0; i < boardSize; i++)
            {
                temp += (boardSize - i) + "\t";

                for (int j = 0; j < boardSize; j++)
                {
                    temp += board[i, j] + "\t";
                }

                temp += '\n';
            }

            temp += "\t";
            for (int w = 0; w < letters.Count; w++)
            {
                temp += $" {letters.ElementAt(w).ToString().ToUpper()}\t";
            }

            Console.WriteLine(temp);
        }

        public IEnumerator GetEnumerator()
        {
            List<string> list = new List<string>();
            string boardCell;

            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    boardCell = board[i, j];

                    if (!boardCell.Contains(fillPattern1) && !boardCell.Contains(fillPattern2))
                    {
                        list.Add(board[i, j]);
                    }
                }
            }

            return list.GetEnumerator();
        }

        #endregion
    }

    static class ChessBoardExtensions
    {
        public static int FigureCount(this Plansza board)
        {
            int count = 0;

            foreach (var b in board)
            {
                count++;
            }

            return count;
        }
    }
}
