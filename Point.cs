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

        //Конструкторы
        public Point()
        {

        }
        
        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        //Функция рисования
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);

        }
    }
}
