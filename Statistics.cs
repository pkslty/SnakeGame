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
            this.speed = Math.Round((double)second/delay, 2);
        }

        public void printStatistics(int x)
        {
            Console.SetCursorPosition(x, 3);
            Console.WriteLine("Statistics");

            Console.SetCursorPosition(x, 5);
            Console.WriteLine("Score:");
            Console.SetCursorPosition(x, 6);
            Console.WriteLine(score);
            Console.SetCursorPosition(x, 8);
            Console.WriteLine("Snake length:");
            Console.SetCursorPosition(x, 9);
            Console.WriteLine(length);
            Console.SetCursorPosition(x, 11);
            Console.WriteLine("Snake speed");
            Console.SetCursorPosition(x, 12);
            Console.WriteLine("chars/second:");
            Console.SetCursorPosition(x, 13);
            Console.WriteLine(speed);

        }
    }
}
