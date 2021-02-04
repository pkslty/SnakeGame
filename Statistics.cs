using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    class Statistics
    {
        double speed;
        int score;
        int length;

        
        public Statistics(int delay, int length)
        {
            this.score = 0;
            this.speed = Math.Round((double)1000 / delay, 2);
            this.length = length;
        }

        public void setStatistics(int delay, int length)
        {
            const int second = 1000; //milliseconds
            this.score += 1;
            this.length = length;
            this.speed = Math.Round((double)1000/delay, 2);
        }

        public void printStatistics(int x)
        {
            Console.SetCursorPosition(x, 3);
            Console.Write("Statistics");

            Console.SetCursorPosition(x, 5);
            Console.Write("Score:");
            Console.SetCursorPosition(x, 6);
            Console.Write(score);
            Console.SetCursorPosition(x, 8);
            Console.Write("Snake length:");
            Console.SetCursorPosition(x, 9);
            Console.Write(length);
            Console.SetCursorPosition(x, 11);
            Console.Write("Snake speed");
            Console.SetCursorPosition(x, 12);
            Console.Write("chars/second:");
            Console.SetCursorPosition(x, 13);
            Console.Write(speed);

        }
    }
}
