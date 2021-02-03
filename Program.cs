using System;
using System.Collections.Generic;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(122, 32);
            Console.SetBufferSize(122, 32);
            Console.CursorVisible = false;

            HorizontalLine line1 = new HorizontalLine(1, 120, 1, '#');
            line1.Draw();
            HorizontalLine line2 = new HorizontalLine(1, 120, 30, '#');
            line2.Draw();
            VerticalLine line3 = new VerticalLine(1, 30, 1, '#');
            line3.Draw();
            VerticalLine line4 = new VerticalLine(1, 30, 120, '#');
            line4.Draw();

            Point p1 = new Point(50, 10, '*');
            Snake snake = new Snake(p1, 5, Direction.LEFT);
            snake.Draw();




            //Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
