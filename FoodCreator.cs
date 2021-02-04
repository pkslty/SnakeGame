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
            ConsoleColor value;
            Point food;
            int x = random.Next(xBoundMin, xBoundMax);
            int y = random.Next(yBoundMin, yBoundMax);

            do
            {
                value = RandomEnumValue<ConsoleColor>();
                food = new Point(x, y, this.kind, value, ConsoleColor.Black);
            } while (value == ConsoleColor.Black);
            

            return food;
        }

        static Random _R = new Random();
        private T RandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(_R.Next(v.Length));
        }
    }
}
