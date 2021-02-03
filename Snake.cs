using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
            
        }

    }
}
