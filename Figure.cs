using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class Figure
    {
        //Список точек
        protected List<Point> pList;

        //Вывод фигуры на экран
        public void Draw()
        {
            foreach (Point p in pList)
                p.Draw();
        }

        public bool isHit(Figure figure)
        {
            foreach(var point in this.pList)
            {
                foreach (var fpoint in figure.pList)
                    if (fpoint.isHit(point))
                        return true;
            }
            return false;
        }
        public bool isHit(Point point)
        {
               foreach (var p in this.pList)
                    if (p.isHit(point))
                        return true;
            return false;
        }

    }
}
