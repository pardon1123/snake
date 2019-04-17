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
            //Point p1 = new Point(1, 1, '*');

            //Point p2 = new Point(1, 2, '*');

            HorLn line = new HorLn(3, 9, 5, '_');
            line.Draw();

            VertLn line2 = new VertLn(6, 10, 6, '|');
            line2.Draw();

            Console.ReadKey();
        }
    }
}
