using ProgramSzachy.Szachy.Plansza;

namespace ProgramSzachy.Szachy.Figura
{
    class Wieza : Figure
    {
        private const string NAME = "Wieza";

        public Wieza(string color, Pozycja pos = null)
            : base(NAME, color, pos)
        {
        }

        protected override bool CanBeMoved(string pozycja)
        {

            return true;
        }
    }
}
