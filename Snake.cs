using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SnakeGame
{
    class Snake : Figure
    {
        public Direction direction;
        int length;

        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;
            this.length = length;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }        
        }

        public void Move()
        {
            Point tail = pList[0];
            Point newHead = makeNewHead();
            pList.Add(newHead);
            pList.Remove(tail);
            tail.Clear();
            newHead.Draw();
        }

        public Point makeNewHead()
        {
            Point head = pList.Last();
            Point newHead = new Point(head);
            newHead.Move(1, direction);

            return newHead;
        }

        public bool HaveEat(Point food)
        {
            Point head = makeNewHead();
            if (head.isHit(food))
            {
                food.symbol = head.symbol;
                pList.Add(food);
                food.Draw();
                return true;
            }
            return false;
        }
    }
}
