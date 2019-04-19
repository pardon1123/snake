﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Line
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point p in pList)
                p.Draw();
        }

        internal bool IsHit(Line line)
        {
            foreach (var p in pList)
            {
                if (line.IsHit(p))
                    return true;
            }
            return false;
        }
        private bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
