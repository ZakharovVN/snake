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
            
            // рамка
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '#');
            HorizontalLine downline = new HorizontalLine(0, 78, 24, '#');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '#');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '#');
            upLine.Drow();
            downline.Drow();
            leftline.Drow();
            rightLine.Drow();

            // рамка

           
            Point p = new Point(4, 5, '#');            
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            Console.ReadLine();



        }
        
    
    }
}
