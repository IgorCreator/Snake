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
            Point p1 = new Point(1,3,'*'); // создание дополнительных точек
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            Point p3 = new Point(8, 5, '#');
            p3.Draw();

            Point p4 = new Point(12, 3, '*');
            p4.Draw();

            List<int> numList = new List<int>();    // создание Листа с помощью абстрактного класса 
            numList.Add(0);                        // List(т.е. мы не знаем как он внутри работает - нам важен вывод)
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];
            Console.SetCursorPosition(4, 8);

            foreach (int i in numList)
            {
                Console.Write(i);
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();  // Лист для наших точек
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            foreach (int n in numList)
            {
                Console.Write(n);
            }


            for (int m=10; m<20; m++)     // рисование в консоли
            {
                Point p7 = new Point(m, m, '#');
                p7.Draw();
            }


            Console.ReadLine();
        }
    }
}
