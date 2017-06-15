using ProgramSzachy.Szachy.Wlasciwosci;
using System;

namespace ProgramSzachy.Szachy.Plansza
{
    public class Pozycja
    {
        #region Properties

        public char X { get; }

        public int iX { get; }
        public int Y { get; }

        #endregion

        #region Constructors and Destructors

        public Pozycja(char X, int Y)
        {
            if (CheckBounds(Stala.BOARD_SIZE, charToChessInt(X), Y))
            {
                this.X = X;
                this.Y = Y;
                this.iX = charToChessInt(X);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        #endregion

        #region Private Methods

        private bool CheckBounds(int boardSize, params int[] values)
        {
            bool result = true;

            foreach (int value in values)
            {
                if (!(value >= 0 && value - 1 <= boardSize))
                {
                    result = false;
                }
            }

            return result;
        }

        private int charToChessInt(char c)
        {
            return c - 65;
        }

        #endregion
    }
}
