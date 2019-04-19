using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize(80, 25);

            //Рамка
            HorLn upLine = new HorLn(0, 78, 0, '+');
            HorLn downLine = new HorLn(0, 78, 24, '+');
            VertLn leftLine = new VertLn(0, 24, 0, '+');
            VertLn rightLine = new VertLn(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(4,5,'*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            snake.Move();
            Thread.Sleep(500);
            snake.Move();
            Thread.Sleep(500);
            snake.Move();
            Thread.Sleep(500);
            snake.Move();
            Thread.Sleep(500);

            Console.ReadKey();
        }
    }
}
