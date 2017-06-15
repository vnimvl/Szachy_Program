using ProgramSzachy.Szachy;
using ProgramSzachy.Szachy.Figura;
using ProgramSzachy.Szachy.Plansza;
using ProgramSzachy.Szachy.Figura.Enums;
using ProgramSzachy.Szachy.Wlasciwosci.Extensions;
using System;

namespace ProgramSzachy.Szachy.Figura
{
    static class FigureFactory // tworzenie Metody wytworczej 
    {
        public static Figure CreateFigure(FigureType figure, Colors color, Pozycja pos = null)
        {
            Figure retFigure = null;

            switch (figure)
            {
                case FigureType.Pionek:
                    {
                        retFigure = new Pionek(color.Name(), pos);
                        break;
                    }
                case FigureType.Krol:
                    {
                        retFigure = new Krol(color.Name(), pos);
                        break;
                    }
                case FigureType.Wieza:
                    {
                        retFigure = new Wieza(color.Name(), pos);
                        break;
                    }
                case FigureType.Krolowa:
                    {
                        retFigure = new Krolowa(color.Name(), pos);
                        break;
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException("figure", "Unknown figure type");
                    }
            }

            return retFigure;
        }
    }
}
