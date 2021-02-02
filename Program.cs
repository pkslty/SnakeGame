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

            Point p1 = new Point(1, 5, '#');
            Point p2 = new Point();
            p2.x = 3;
            p2.y = 6;
            p2.symbol = '*';
            p1.Draw();
            p2.Draw();

            HorizontalLine line1 = new HorizontalLine(1, 120, 1, '#');
            line1.Draw();
            HorizontalLine line2 = new HorizontalLine(1, 120, 30, '#');
            line2.Draw();
            VerticalLine line3 = new VerticalLine(1, 30, 1, '#');
            line3.Draw();
            VerticalLine line4 = new VerticalLine(1, 30, 120, '#');
            line4.Draw();






            //Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
