using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class Point
    {
        //Координаты точки
        public int x, y;
        public char symbol;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);

        }

    }
}
