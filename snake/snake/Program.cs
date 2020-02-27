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
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '+');
            p2.Draw();

            Console.WriteLine("\n\n");
            Console.WriteLine($"p1 = {p1.x}, {p1.y}, {p1.sym}");
            Console.WriteLine($"p2 = {p2.x}, {p2.y}, {p2.sym}");

            p1 = p2;
            
            Console.WriteLine("\np1 = p2");
            Console.WriteLine($"p1 = {p1.x}, {p1.y}, {p1.sym}");
            Console.WriteLine($"p2 = {p2.x}, {p2.y}, {p2.sym}");

            p2.x++;
            p2.y++;
            Console.WriteLine($"p2++");
            Console.WriteLine($"p1 = {p1.x}, {p1.y}, {p1.sym}");
            Console.WriteLine($"p2 = {p2.x}, {p2.y}, {p2.sym}");

            Reset(p2);

            Console.ReadLine();
        }

        private static void Reset(Point p)
        {
            p = new Point();
            Console.WriteLine($"p = {p.x}, {p.y}, {p.sym}");
        }
    }
}
