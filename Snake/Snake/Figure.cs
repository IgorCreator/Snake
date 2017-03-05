using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure 
    {
        protected List<Point> pList;  //protected - т.к. наш лист лист точек должен 
                                      //передаться дочерним классам(без реализации будет ошибка т.е. мы не объявим ""лист точек)
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
