using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GameController gameController = new GameController();
            gameController.StartScreen();
            
            int hs = Console.LargestWindowHeight;
            int ws = 2 * hs;
            int delay = 120;

            int startSnakeLength = 2;

            walls walls = gameController.walls;
            walls.Draw();


            Snake snake = gameController.snake;
            snake.Draw();
            Statistics statistics = gameController.statistics;
            FoodCreator foodCreator = gameController.foodCreator;

            Food food = foodCreator.CreateNewFood();
            food.Draw();

            while (true)
            {
                if (walls.isHit(snake) || snake.isHitTail())
                    break;
                if (Console.KeyAvailable) {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.direction = gameController.keyHandler(snake.direction, key);
                }
                if (snake.HaveEat(food))
                {
                    if (food.kind == '-')
                    {
                        snake.throwTail();
                        snake.throwTail();
                    }
                    if (food.kind == 'F')
                        delay = (int) (delay * 0.95);
                    else if (food.kind == 'S')
                        delay = (int) (delay / 0.95);

                    statistics.setStatistics(delay, snake.length);
                    do
                    {
                        food = foodCreator.CreateNewFood();
                    } while (!walls.isHit(food) && snake.isHit(food));
                    food.Draw();
                }
                else
                {
                    snake.Move();
                    
                }
                Thread.Sleep(delay);
                statistics.printStatistics(ws+1);
            }




            //Console.WriteLine("Hello World!");
            Console.WriteLine("GAME OVER");
            Console.ReadLine();
        }
    }
}
