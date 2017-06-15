using ProgramSzachy.Szachy.Plansza;
using System;

namespace ProgramSzachy.Szachy
{
    abstract class Figure
    {
        #region Delegates and Events

        public delegate void PositionChangeHandler();
        public event PositionChangeHandler OnPositionChange;

        #endregion

        #region Properties

        public string Color { get; set; }
        public string Name { get; set; }
        private Pozycja pozycja;
        public Pozycja Pozycja
        {
            get
            {
                return pozycja;
            }
            set
            {
                if (null != OnPositionChange) OnPositionChange();
                pozycja = value;
            }
        }

        #endregion

        #region Constructors and Destructors

        public Figure(string name, string color, Pozycja pos)
        {
            Name = name;
            Color = color;
            Pozycja = pos;
            OnPositionChange += PositionChanged;
        }

        #endregion

        #region Protected Methods

        protected abstract bool CanBeMoved(string pozycja);

        #endregion

        #region Public Methods

        public string ShortName()
        {
            return Color[0].ToString() + Name[0].ToString();
        }

        public override string ToString()
        {
            return $"Base class: {Color} {Name}";
        }

        public void PositionChanged()
        {
            Console.WriteLine($"{Name} Zmieniona pozycja");
        }

        #endregion
    }
}
