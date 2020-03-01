using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            HorizontalLine topline = new HorizontalLine(0, 78, 0, '*');
            HorizontalLine bottomline = new HorizontalLine(0, 78, 24, '*');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '*');
            VerticalLine rightline = new VerticalLine(0, 24, 78, '*');
            topline.DrawLine();
            bottomline.DrawLine();
            leftline.DrawLine();
            rightline.DrawLine();

            Point p = new Point(5, 10, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            
            while(true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handle(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

            //Console.ReadLine();
        }

    }
}
