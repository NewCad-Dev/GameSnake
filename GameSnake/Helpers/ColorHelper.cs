using System;

namespace GameSnake.Helpers
{
    static class ColorHelper
    {
        public static ConsoleColor GetRamdomColor(int value)
        {
            switch (value)
            {
                case 1:
                    return ConsoleColor.Green;
                case 2:
                    return ConsoleColor.Red;
                case 3:
                    return ConsoleColor.Yellow;
                case 4:
                    return ConsoleColor.Magenta;
                case 5:
                    return ConsoleColor.Blue;
                default:
                    return ConsoleColor.White;
            }
        }
    }
}