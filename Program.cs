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

            int startSnakeLength = 2;
            //Console.Write(Console.LargestWindowWidth);
            //Console.ReadLine();
            //Console.Write(Console.LargestWindowHeight);
            //Console.ReadLine();

            Console.SetWindowSize(ws, hs);
            Console.SetBufferSize(ws, hs);
            Console.CursorVisible = false;

            walls walls = new walls(0, 0, ws - 1, hs - 1, '+');
            walls.Draw();


            Point p1 = new Point(50, 10, '*');
            Snake snake = new Snake(p1, startSnakeLength, Direction.LEFT);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(2, ws - 2, 2, hs - 2, '$');

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
                    food = foodCreator.CreateNewFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                    
                }
                Thread.Sleep(100);
            }




            //Console.WriteLine("Hello World!");
            Console.WriteLine("GAME OVER");
            Console.ReadLine();
        }
    }
}
