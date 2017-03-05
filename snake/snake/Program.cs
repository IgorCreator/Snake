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
            //Console.SetBufferSize(85,30);


            //Рисуем рамку
            HorizontalLine lineUpH = new HorizontalLine(0, 78, 0, '-');
            HorizontalLine lineDownH = new HorizontalLine(0, 78, 24, '-');
            lineUpH.Draw();
            lineDownH.Draw();

            VerticalLine lineleftV = new VerticalLine(0, 24, 0, '|');
            VerticalLine lineRightV = new VerticalLine(0, 24, 78, '|');
            lineleftV.Draw();
            lineRightV.Draw();

            //Корректируем углы
            Point corner1 = new Point(0,0,'+');
            Point corner2 = new Point(0, 24, '+');
            Point corner3 = new Point(78, 0, '+');
            Point corner4 = new Point(78, 24, '+');
            corner1.Draw();
            corner2.Draw();
            corner3.Draw();
            corner4.Draw();

            //Начальная позиции для змейки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p,4,Direction.RIGHT);
            snake.Draw();

            while (true) {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();    // по нажатию клавиши осущ. движение змейки
                    snake.HandleKey(key.Key);
                    
                }
                

                System.Threading.Thread.Sleep(100);
                snake.Move();
                

            }

            
           


            //Что бы сонсоль закрывалась после нажатия клавиши
            Console.ReadLine();
        }
    }
}
