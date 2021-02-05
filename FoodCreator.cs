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
        ConsoleColor backGrounColor;

        public FoodCreator(int xBoundMin, int xBoundMax, int yBoundMin, int yBoundMax, ConsoleColor backGrounColor)
        {
            this.xBoundMin = xBoundMin;
            this.xBoundMax = xBoundMax;
            this.yBoundMin = yBoundMin;
            this.yBoundMax = yBoundMax;
            this.backGrounColor = backGrounColor;
        }

        public Food CreateNewFood()
        {
            Random random = new Random();
            ConsoleColor randomColor;
            char randomKind;
            Food food;
            int x = random.Next(xBoundMin, xBoundMax);
            int y = random.Next(yBoundMin, yBoundMax);

            randomKind = (char)RandomEnumValue<FoodKind>();
            do
            {
                randomColor = RandomEnumValue<ConsoleColor>();
            } while (randomColor == ConsoleColor.Black);
            
            food = new Food(x, y, randomKind, randomColor, backGrounColor);

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
