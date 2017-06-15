using ProgramSzachy.Szachy.Plansza;

namespace ProgramSzachy.Szachy.Figura
{
    class Krolowa : Figure
    {
        private const string NAME = "Krolowa";

        public Krolowa(string color, Pozycja pos = null)
            : base(NAME, color, pos)
        {
        }

        protected override bool CanBeMoved(string pozycja)
        {

            return true;
        }
    }
}
