using GameSnake.UserServices;
using System;
using System.Collections.Generic;

namespace GameSnake.UI
{
    class UIService
    {
        private UserService _userServices = new UserService();
        private User _user = new User();

        public void GetMenu()
        {
            GraphicMenu();
        }

        private void GraphicMenu()
        {
            Console.Clear();
            for (int i = 5; i < 23; i++)
            {
                Console.SetCursorPosition(30, i);
                Console.WriteLine($"||{new string(' ', 55)}||");
            }

            Console.SetCursorPosition(32, 5);
            Console.WriteLine(new string('=', 55));

            for (int i = 6; i < 11; i++)
            {
                Console.SetCursorPosition(32, i);
                Console.WriteLine(new string('-', 55));
            }

            Console.SetCursorPosition(49, 8);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Welcom to Snake Game ");
            Console.ResetColor();

            Console.SetCursorPosition(44, 12);
            Console.WriteLine("- Press Enter to Start the Game");
            Console.SetCursorPosition(44, 14);
            Console.WriteLine("- Use Arrows to Move the Snake");
            Console.SetCursorPosition(44, 16);
            Console.WriteLine("- Press C to Create the User");
            Console.SetCursorPosition(44, 18);
            Console.WriteLine("- Press S to Get all Scores");
            Console.SetCursorPosition(44, 20);
            Console.WriteLine("- Press ESC to Quite the Game");

            Console.SetCursorPosition(32, 22);
            Console.WriteLine(new string('=', 55));
        }

        public void GetCommand(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.Enter:
                    StartGame();
                    break;
                case ConsoleKey.C:
                    CreateUserForms();
                    break;
                case ConsoleKey.S:
                    ScoreBoard();
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
                default:
                    GetMenu();
                    break;
            }
        }

        private void StartGame()
        {
            Console.Clear();
            GamePlay play = new GamePlay();
            play.StartGame(_user);
        }

        private void CreateUserForms()
        {
            Console.Clear();
            Console.WriteLine("Create User:");

            Create:
            Console.Write("Enter your name please: ");
            string nameUser = Console.ReadLine();

            try
            {
                _user = _userServices.CreateUser(nameUser);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                goto Create;
            }

            Console.WriteLine("The user was saved");

            GoBack();
        }

        private void ScoreBoard()
        {
            Console.Clear();
            IEnumerable<User> users = _userServices.GetAllUsers();
            foreach (User user in users)
            {
                Console.WriteLine($"User: {user.Name} with Score: {user.Score};");
            }

            GoBack();
        }

        private void GoBack()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press ESC to back");
            Console.ResetColor();

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
                GetMenu();
            else
                GoBack();
        }
    }
}
