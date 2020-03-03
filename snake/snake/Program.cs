using System;
using System.Collections.Generic;
using System.Threading;

namespace snake
{
    class Program
    {
        const int MINXY = 0;
        const char HVLINE = '*';
        const int WIDTH = 100;
        const int HEIGHT = 40;
        static void Main(string[] args)
        {
            //Console.SetWindowSize(1, 1);
            Console.SetWindowSize(WIDTH + 2, HEIGHT + 1);
            Console.SetBufferSize(WIDTH + 2, HEIGHT + 1);
            

            HorizontalLine topline = new HorizontalLine(MINXY, WIDTH, MINXY, HVLINE);
            HorizontalLine bottomline = new HorizontalLine(MINXY, WIDTH, HEIGHT, HVLINE);
            VerticalLine leftline = new VerticalLine(MINXY, HEIGHT, MINXY, HVLINE);
            VerticalLine rightline = new VerticalLine(MINXY, HEIGHT, WIDTH, HVLINE);
            topline.DrawLine();
            bottomline.DrawLine();
            leftline.DrawLine();
            rightline.DrawLine();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.DrawLine();

            FoodCreator foodCreator = new FoodCreator(WIDTH, HEIGHT, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();


            while(true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handle(key.Key);
                }
                
            }

            //Console.ReadLine();
        }

    }
}
