using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 1, '*');

            //p1.Draw();

            Point p2 = new Point(1, 2, '*');

            //p2.Draw(); ;

            Point p3 = new Point(1, 3, '*');

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);

            foreach (var item in pList)
            {
                item.Draw();
            }

            Console.ReadKey();
        }
    }
}
