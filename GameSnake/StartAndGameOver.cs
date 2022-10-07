using GameSnake.UI;
using System;

namespace GameSnake
{
    class StartAndGameOver
    {
        UIService uiService = new UIService();

        public void StartGame()
        {
            Console.Clear();
            Collor();
            Console.WriteLine(@"
                                   _____ __             __     ______                   
                                  / ___// /_____ ______/ /_   / ____/___ _____ ___  ___ 
                                  \__ \/ __/ __ `/ ___/ __/  / / __/ __ `/ __ `__ \/ _ \
                                 ___/ / /_/ /_/ / /  / /_   / /_/ / /_/ / / / / / /  __/
                                /____/\__/\__,_/_/   \__/   \____/\__,_/_/ /_/ /_/\___/");
            Console.ResetColor();
            Console.SetCursorPosition(45, 18);
            Console.WriteLine("Press Enter to Start the Game");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Enter)
                uiService.GetMenu();
            else
                StartGame();
        }

        public void GameOver()
        {
            Console.Clear();
            Collor();
            Console.WriteLine(@"
                                   ______                        ____                 
                                  / ____/___ _____ ___  ___     / __ \_   _____  _____
                                 / / __/ __ `/ __ `__ \/ _ \   / / / / | / / _ \/ ___/
                                / /_/ / /_/ / / / / / /  __/  / /_/ /| |/ /  __/ /    
                                \____/\__,_/_/ /_/ /_/\___/   \____/ |___/\___/_/");
            Console.ResetColor();
            Console.SetCursorPosition(45, 18);
            Console.WriteLine("To try again press ESC");
            ConsoleKeyInfo key = Console.ReadKey();
            GetCommand(key.Key);
        }

        private void Collor()
        {
            Console.SetCursorPosition(30, 10);
            Console.ForegroundColor = ConsoleColor.Green;
        }

        private void GetCommand(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.Escape:
                    uiService.GetMenu();
                    break;
                default:
                    GameOver();
                    break;
            }
        }
    }
}
