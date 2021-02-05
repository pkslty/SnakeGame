using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class Food : Point
    {
        public char kind;
        
        public Food(int x, int y, char symbol, ConsoleColor color, ConsoleColor backGroundColor)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
            this.color = color;
            this.kind = symbol;
            this.backGroundColor = backGroundColor;
        }
    }
}
