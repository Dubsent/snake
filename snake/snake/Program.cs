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
            int sym1 = 33;
            int sym2 = 42;
            int point_count = 4;

            Random rnd = new Random();

            List<int> numList = new List<int>();
            for (int i = 0; i < point_count * 2; i++)
            {
                numList.Add(rnd.Next(0, 10));
            }

            List<char> charList = new List<char>();
            for (int i = sym1; i <= sym2; i++)
            {
                charList.Add((char)i);
            }

            List<Point> pList = new List<Point>();
            for (int i = 0; i < point_count; i++)
            {
                pList.Add(new Point(numList[i], numList[i+1], charList[rnd.Next(i, charList.Count)]));
            }

            foreach (Point p in pList) 
            { 
                p.Draw();
            }

            Console.ReadLine();
        }

    }
}
