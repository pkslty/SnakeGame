using System;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 5, '#');
            Point p2 = new Point();
            p2.x = 3;
            p2.y = 6;
            p2.symbol = '*';
            p1.Draw();
            p2.Draw();

            //Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
