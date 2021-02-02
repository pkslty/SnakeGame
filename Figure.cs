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
    }
}
