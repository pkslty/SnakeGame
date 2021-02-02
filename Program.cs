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

            List<int> numList = new List<int>(2);
            numList[1] = 345;
            numList[2] = 3214;

            List<string> varList = new List<string>();
            varList[6] = "string";

            List<Point> pList = new List<Point>();
            pList[0] = p1;
            pList[1] = p2;

            List<int> iList = new List<int>();
            iList[0] = 1;
            iList[10] = 2;
            iList[40] = 4;


            //Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
