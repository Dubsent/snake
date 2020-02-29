using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(4, 3 , '*');
            p1.Draw();
            Point p2 = new Point(7, 6, '#');
            p2.Draw();

            HorizontalLine horline = new HorizontalLine(5, 10, 8, '+');
            horline.DrawLine();

            VerticalLine verline = new VerticalLine(8, 16, 16, '^');
            verline.DrawLine();

            Console.ReadLine();
        }

    }
}
