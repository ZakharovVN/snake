using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // рамка
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '#');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '#');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '#');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '#');
            upLine.Draw();
            downline.Draw();
            leftline.Draw();
            rightLine.Draw();

            // рамка

           
            Point p = new Point(4, 5, '#');            
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            
            snake.Draw();
            snake.Move();
            Thread.Sleep (300);
            snake.Move();
            Thread.Sleep (300);
            snake.Move();
            Thread.Sleep (300);
            snake.Move();
            Thread.Sleep (300);
            snake.Move();
            Thread.Sleep (300);
            snake.Move();
            Thread.Sleep (300);
            snake.Move();
            Thread.Sleep (300);
            snake.Move();
            Thread.Sleep (300);
            


            Console.ReadLine();



        }
        
    
    }
}
