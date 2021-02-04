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
            int hs = Console.LargestWindowHeight;
            int ws = 2 * hs;
            int delay = 120;

            int startSnakeLength = 2;
            //Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.ReadLine();
            //Console.Write(Console.LargestWindowHeight);
            //Console.ReadLine();

            Console.SetWindowSize(ws+14, hs);
            Console.SetBufferSize(ws+14, hs);
            Console.CursorVisible = false;

            walls walls = new walls(0, 0, ws - 1, hs - 1, '#');
            walls.Draw();



            Point tail = new Point(25, 10, '*', ConsoleColor.Cyan, ConsoleColor.Black);
            Snake snake = new Snake(tail, startSnakeLength, Direction.LEFT);
            snake.Draw();
            Statistics statistics = new Statistics(delay, snake.length);
            FoodCreator foodCreator = new FoodCreator(2, ws - 2, 2, hs - 2, '+');

            Point food = foodCreator.CreateNewFood();
            food.Draw();
            while (true)
            {
                if (walls.isHit(snake) || snake.isHitTail())
                    break;
                if (Console.KeyAvailable) {
                    ConsoleKeyInfo key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            if (snake.direction != Direction.RIGHT)
                                snake.direction = Direction.LEFT;
                            break;
                        case ConsoleKey.RightArrow:
                            if (snake.direction != Direction.LEFT)
                                snake.direction = Direction.RIGHT;
                            break;
                        case ConsoleKey.UpArrow:
                            if(snake.direction != Direction.DOWN)
                                snake.direction = Direction.UP;
                            break;
                        case ConsoleKey.DownArrow:
                            if(snake.direction != Direction.UP)
                                snake.direction = Direction.DOWN;
                            break;
                        default:
                            break;
                    }
                }
                if (snake.HaveEat(food))
                {
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
