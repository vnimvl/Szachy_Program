using ProgramSzachy.Szachy.Plansza;

namespace ProgramSzachy.Szachy.Figura
{
    class Krol : Figure
    {
        private const string NAME = "Krol";

        public Krol(string color, Pozycja pos = null)
            : base(NAME, color, pos)
        {
        }

        protected override bool CanBeMoved(string pozycja)
        {

            return true;
        }

        public new string ToString()
        {
            return $"Krol class: {Color} {Name}";
        }
    }
}
