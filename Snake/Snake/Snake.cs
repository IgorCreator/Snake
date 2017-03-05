using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake:Figure
    {
        public Direction direction; // запоминаем направление

        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>(); 
            for (int i=0; i<lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move() //реализация класса движения
        {
            Point tail = pList.First(); //возвращаю первый элемент списка
            pList.Remove(tail);         // хвост "не принадлежит больше змейке" т.к. она двигается вперёд
            Point head = GetNextPoint(); //Дай точку для движения головы
            pList.Add(head);             // Двигаем голову
                                         //(иллюзия движения)
            tail.Clear();                  //стираю последнюю точку хвоста
            head.Draw();                    //Рисую новую
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();     //нахожу текущую поз. - до движения
            Point nextPoint = new Point(head);  //копия предыдущего положения
            nextPoint.Move(1, direction);  //свинул на единицу в необходимомое направление
            return nextPoint;               //вернул значение новой точки

        }

        public void HandleKey(ConsoleKey key)   // сама реализаия движения змейки при нажатии на клавишу
        {
                    if (key == ConsoleKey.LeftArrow)
                        direction = Direction.LEFT;
                    else if (key == ConsoleKey.RightArrow)
                        direction = Direction.RIGHT;
                    else if (key == ConsoleKey.DownArrow)
                       direction = Direction.DOWN;
                    else if (key == ConsoleKey.UpArrow)
                       direction = Direction.UP;
        }
    }
}
