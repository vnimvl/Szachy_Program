using ProgramSzachy.Szachy.Plansza;

namespace ProgramSzachy.Szachy.Figura
{
    class Pionek : Figure
    {
        private const string NAME = "Pionek";

        public Pionek(string color, Pozycja pos = null)
            : base(NAME, color, pos)
        {
        }

        protected override bool CanBeMoved(string pozycja)
        {

            return true;
        }
    }
}
