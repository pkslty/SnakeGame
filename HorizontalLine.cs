using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    //Горизонтальная линия, заданная координатами начала и конца и символами    
    class HorizontalLine
    {
        static List<Point> pList;

        public HorizontalLine(int startX, int endX, int y, char symbol)
        {
            pList = new List<Point>();
            for(int i = startX; i <= endX; i++)
            {
                Point p = new Point(i, y, symbol);
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
