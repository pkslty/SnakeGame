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
        public int length;

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
                this.length += 1;
                return true;
            }
            return false;
        }


        public bool isHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
                if (head.isHit(pList[i]))
                    return true;
            return false;
        }
    }
}
