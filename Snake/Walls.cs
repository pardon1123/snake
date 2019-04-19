using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Line> wallList;

        public Walls(int mapWidht, int mapHeight)
        {
            wallList = new List<Line>();

            //Отрисовка рамки
            HorLn upLine = new HorLn(0, mapWidht-2, 0, '+');
            HorLn downLine = new HorLn(0, mapWidht - 2, mapHeight-1, '+');
            VertLn leftLine = new VertLn(0, mapHeight - 1, 0, '+');
            VertLn rightLine = new VertLn(0, mapHeight - 1, mapWidht - 2, '+');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Line line)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(line))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
