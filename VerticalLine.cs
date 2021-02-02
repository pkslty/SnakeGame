using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    //Вертикальная линия, заданная координатами начала и конца и символами  
    class VerticalLine
    {
        static List<Point> pList;

        public VerticalLine(int startY, int endY, int x, char symbol)
        {
            pList = new List<Point>();
            for (int i = startY; i <= endY; i++)
            {
                Point p = new Point(x, i, symbol);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in pList)
                p.Draw();
        }
    }
}
