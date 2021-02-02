using System;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 1;
            p1.y = 5;
            p1.symbol = '#';
            p1.Draw();

            //Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
