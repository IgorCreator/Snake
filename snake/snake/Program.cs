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
            HorizontalLine lineH = new HorizontalLine(5, 25, 4, '-');
            lineH.Draw();

            VerticalLine lineV = new VerticalLine(4, 14, 5, '|');
            lineV.Draw();

            Console.ReadLine();
        }
    }
}
