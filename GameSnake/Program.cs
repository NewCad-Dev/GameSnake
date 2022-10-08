using GameSnake.UI;
using System;

namespace GameSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            StartAndGameOver start = new StartAndGameOver();
            start.StartGame();

            UIService ui = new UIService();

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                ui.GetCommand(key.Key);
            }
        }
    }
}
