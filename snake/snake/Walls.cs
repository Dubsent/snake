using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            
            HorizontalLine topline = new HorizontalLine(0, mapWidth, 0, '+');
            HorizontalLine bottomline = new HorizontalLine(0, mapWidth, mapHeight, '+');
            VerticalLine leftline = new VerticalLine(0, mapHeight, 0, '+');
            VerticalLine rightline = new VerticalLine(0, mapHeight, mapWidth, '+');
            
            wallList.Add(topline);
            wallList.Add(bottomline);
            wallList.Add(leftline);
            wallList.Add(rightline);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            } return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.DrawLine();
            }
        }
    }
}
