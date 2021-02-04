using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SnakeGame
{
    class Point
    {
        //Координаты точки
        public int x, y;
        public char symbol;
        public ConsoleColor backGroundColor;
        public ConsoleColor color;

        //Конструкторы
        public Point()
        {

        }
        //Создание точки по координатам и символу
        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
            this.color = Console.ForegroundColor;
            this.backGroundColor = Console.BackgroundColor;
        }

        //Создание точки с цветами, отличными от настроек консоли
        public Point(int x, int y, char symbol, ConsoleColor color, ConsoleColor backGroundColor)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
            this.color = color;
            this.backGroundColor = backGroundColor;
        }

        //Создание точки по точке
        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            this.symbol = p.symbol;
            this.color = p.color;
            this.backGroundColor = p.backGroundColor;
        }

        //Функция рисования
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            ConsoleColor color = Console.ForegroundColor;
            ConsoleColor backGroundColor = Console.BackgroundColor;
            Console.BackgroundColor = this.backGroundColor;
            Console.ForegroundColor = this.color;
            Console.Write(symbol);
            Console.BackgroundColor = backGroundColor;
            Console.ForegroundColor = color;

        }
        //Функция стирания
        public void Clear()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');

        }

        public bool isHit(Point p)
        {
            return (this.x == p.x) && (this.y == p.y);
        }

        //Функция перемещения точки на целое число позиций в заданном направлении
        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.RIGHT:
                    this.x += offset;
                    break;
                case Direction.LEFT:
                    this.x -= offset;
                    break;
                case Direction.UP:
                    this.y -= offset;
                    break;
                case Direction.DOWN:
                    this.y += offset;
                    break;
                default:
                    break;
            }
        }
    }
}
