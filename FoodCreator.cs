using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SnakeGame
{
    class FoodCreator
    {
        int xBoundMin;
        int xBoundMax;
        int yBoundMin;
        int yBoundMax;
        char kind;

        public FoodCreator(int xBoundMin, int xBoundMax, int yBoundMin, int yBoundMax, char kind)
        {
            this.xBoundMin = xBoundMin;
            this.xBoundMax = xBoundMax;
            this.yBoundMin = yBoundMin;
            this.yBoundMax = yBoundMax;
            this.kind = kind;
        }

        public Point CreateNewFood()
        {
            Random random = new Random();
            int x = random.Next(xBoundMin, xBoundMax);
            int y = random.Next(yBoundMin, yBoundMax);
            Point food = new Point(x, y, this.kind);

            return food;
        }
    }
}
