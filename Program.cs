using System;
using System.Collections.Generic;

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

            List<int> numList = new List<int>(2)
            {
                345,
                4325,
                3253,
                132,
                675
            };
            foreach (int i in numList)
                Console.WriteLine(i);

            List<string> varList = new List<string>();
            varList.Add("string");

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Clear();
         


            //Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
