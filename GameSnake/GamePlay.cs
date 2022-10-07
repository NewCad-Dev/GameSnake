using GameSnake.Enums;
using GameSnake.Factory;
using GameSnake.Helpers;
using GameSnake.Installers;
using System;
using System.Threading;

namespace GameSnake
{
    class GamePlay
    {
        public void StartGame()
        {
            int score = 0;

            LineInstaller lineInstaller = new LineInstaller();
            lineInstaller.DrawShapes();

            Point food = FoodFactory.GetRandomFood(119, 20, 'o');
            Food(food);

            Snake snake = new Snake();
            snake.CreateSnake(5, new Point(5, 5, 'x'), DirectionEnum.Right);
            snake.DrawLine();

            ScoreHelper.GetScore(score);

            while (true)
            {
                if (lineInstaller.Collision(snake) || snake.CollisionWithOnTail())
                {
                    Console.Clear();
                    StartAndGameOver gameOver = new StartAndGameOver();
                    gameOver.GameOver();
                    break;
                }

                if (snake.Eat(food))
                {
                    score++;
                    ScoreHelper.GetScore(score);

                    food = FoodFactory.GetRandomFood(119, 20, 'o');
                    Food(food);
                }

                Thread.Sleep(100);
                snake.Move();

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.PressKey(key.Key);
                }
            }
        }

        private void Food(Point point)
        {
            Console.ForegroundColor = ColorHelper.GetRamdomColor(new Random().Next(1, 5));
            point.DrawPoint();
            Console.ResetColor();
        }
    }
}