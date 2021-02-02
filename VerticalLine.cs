using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    //Вертикальная линия, заданная координатами начала и конца и символами  
    class VerticalLine : Figure
    {
        public VerticalLine(int startY, int endY, int x, char symbol)
        {
            pList = new List<Point>();
            for (int i = startY; i <= endY; i++)
            {
                Point p = new Point(x, i, symbol);
                pList.Add(p);
            }
        }
    }
}
