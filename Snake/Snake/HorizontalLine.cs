using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList; //Горизогтальная - это набор точек

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>(); // создание нового пустого списка
            for( int x=xLeft; x<=xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
