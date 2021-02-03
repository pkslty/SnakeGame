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
            int ws = 80, hs = 35;
            Console.SetWindowSize(ws, hs);
            Console.SetBufferSize(ws, hs);
            Console.CursorVisible = false;

            HorizontalLine line1 = new HorizontalLine(1, ws-1, 1, '#');
            line1.Draw();
            HorizontalLine line2 = new HorizontalLine(1, ws-1, hs-1, '#');
            line2.Draw();
            VerticalLine line3 = new VerticalLine(1, hs-1, 1, '#');
            line3.Draw();
            VerticalLine line4 = new VerticalLine(1, hs-1, ws-1, '#');
            line4.Draw();

            Point p1 = new Point(50, 10, '*');
            Snake snake = new Snake(p1, 25, Direction.LEFT);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(2, ws - 2, 2, hs - 2, '$');

            Point food = foodCreator.CreateNewFood();
            food.Draw();
            while (true)
            {
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
            Console.ReadLine();
        }
    }
}
