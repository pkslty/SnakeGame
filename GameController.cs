using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class GameController
    {
        const char WALLS = '#';
        const char SNAKE = '*';
        const int START_SNAKE_LENGTH = 10;
        const Direction START_SNAKE_DIRECTION = Direction.LEFT;
        const ConsoleColor DEF_COLOR = ConsoleColor.Green;
        const ConsoleColor DEF_BACKGROUND_COLOR = ConsoleColor.Black;
        int WINDOW_HEIGTH;
        const int STATISTIC_AREA = 14;
        int WINDOW_WIDTH;// = (Console.LargestWindowWidth < (WINDOW_HEIGTH * 2 + STATISTIC_AREA) ? Console.LargestWindowWidth : WINDOW_HEIGTH * 2 + STATISTIC_AREA);    }
        FoodKind foodKind;
        int delay;
        public walls walls;
        public Snake snake;
        public FoodCreator foodCreator;
        public Statistics statistics;

        public GameController()
        {
            WINDOW_HEIGTH = Console.LargestWindowHeight;
            WINDOW_WIDTH = Console.LargestWindowWidth < (WINDOW_HEIGTH * 2 + STATISTIC_AREA) ? Console.LargestWindowWidth : WINDOW_HEIGTH * 2 + STATISTIC_AREA;
            delay = 120;
            Console.BackgroundColor = DEF_BACKGROUND_COLOR;
            Console.ForegroundColor = DEF_COLOR;
            Console.CursorVisible = false;
            Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGTH);
            Console.SetBufferSize(WINDOW_WIDTH, WINDOW_HEIGTH);
            //Создание стен
            this.walls = new walls(0, 0, WINDOW_WIDTH - STATISTIC_AREA - 1, WINDOW_HEIGTH - 1, WALLS);
            //Создание змейки
            Point tail = new Point((WINDOW_WIDTH - STATISTIC_AREA - 1) /2, (WINDOW_HEIGTH - 1) /2, SNAKE, DEF_COLOR, DEF_BACKGROUND_COLOR);
            this.snake = new Snake(tail, START_SNAKE_LENGTH, START_SNAKE_DIRECTION);
            this.foodCreator = new FoodCreator(2, WINDOW_WIDTH - STATISTIC_AREA - 2, 2, WINDOW_HEIGTH - 2, DEF_BACKGROUND_COLOR);
            this.statistics = new Statistics(delay, this.snake.length);
        }

        public void StartScreen()
        {
            Console.SetCursorPosition((int)WINDOW_WIDTH / 2 - 5, (int)WINDOW_HEIGTH / 3);
            Console.WriteLine("Snake Game"); 
            Console.WriteLine();
            Console.SetCursorPosition((int)WINDOW_WIDTH / 4 , (int)WINDOW_HEIGTH / 3 + 2);
            Console.WriteLine("Meal types:");
            Console.WriteLine();
            Console.SetCursorPosition((int)WINDOW_WIDTH / 4, (int)WINDOW_HEIGTH / 3 + 4);
            Console.WriteLine("+ : Increases snake's length by one char");
            Console.SetCursorPosition((int)WINDOW_WIDTH / 4, (int)WINDOW_HEIGTH / 3 + 5);
            Console.WriteLine("- : Decreases snake's length by one char");
            Console.SetCursorPosition((int)WINDOW_WIDTH / 4, (int)WINDOW_HEIGTH / 3 + 6);
            Console.WriteLine("F : Increases snake's speed by 5 %");
            Console.SetCursorPosition((int)WINDOW_WIDTH / 4, (int)WINDOW_HEIGTH / 3 + 7);
            Console.WriteLine("S : Decreases snake's speed by 5 %");
            Console.SetCursorPosition((int)WINDOW_WIDTH / 4, (int)WINDOW_HEIGTH / 3 + 8);
            Console.WriteLine();
            Console.SetCursorPosition((int)WINDOW_WIDTH / 2 - 6, (int)WINDOW_HEIGTH / 3 + 10);
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();

        }

        public Direction keyHandler(Direction direction, ConsoleKeyInfo key)
        {
            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (direction != Direction.RIGHT)
                        return Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    if (direction != Direction.LEFT)
                        return Direction.RIGHT;
                    break;
                case ConsoleKey.UpArrow:
                    if (direction != Direction.DOWN)
                        return Direction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    if (direction != Direction.UP)
                        return Direction.DOWN;
                    break;
                default:
                    break;
            }
            return direction;
        }
    }
}
