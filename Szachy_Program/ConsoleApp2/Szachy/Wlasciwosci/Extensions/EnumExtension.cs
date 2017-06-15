using ProgramSzachy.Szachy.Figura.Enums;
using System;

namespace ProgramSzachy.Szachy.Wlasciwosci.Extensions
{
    public static class EnumExtensions
    {
        public static string Name(this Colors color)
        {
            return Enum.GetName(typeof(Colors), color);
        }
    }
}
