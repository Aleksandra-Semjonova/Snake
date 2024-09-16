using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{

    /// 1 õppetund
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.Draw();

            // Отрисовка точек			
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            WriteGameOver();
            Console.ReadLine();
        }


        static void WriteGameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("============================", xOffset, yOffset++);
            WriteText("game over", xOffset + 1, yOffset++);
            yOffset++;
            WriteText("", xOffset + 2, yOffset++);
            WriteText("", xOffset + 1, yOffset++);
            WriteText("============================", xOffset, yOffset++);
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

        //VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
        //Draw(v1);

        //Point p = new Point(4, 5, '*');
        //Figure fSnake = new Snake(p, 4, Direction.RIGHT);
        //Draw(fSnake);
        //Snake snake = (Snake)fSnake;

        //HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');

        //List<Figure> figures = new List<Figure>();
        //figures.Add(fSnake);
        //figures.Add(v1);
        //figures.Add(h1);

        //foreach (var f in figures)
        //{
        //    f.Draw();
        //}


        //Console.SetWindowSize(80, 25);

        //Point p1 = new Point(1, 3, '*');
        //p1.Draw();


        //Point p2 = new Point(4, 5, '#');
        //p2.Draw();

        //образовывает рамку 
        //HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
        //HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
        //VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
        //VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
        //upLine.Drow();
        //downLine.Drow();
        //leftLine.Drow();
        //rightLine.Drow();

        //Point p = new Point(4, 5, '*');
        //p.Draw();

        //Snake snake = new Snake(p, 4, Direction.RIGHT);
        //snake.Drow();
        //snake.Move();

        //FoodCreator foodCreator = new FoodCreator(80, 25, '$');
        //Point food = foodCreator.CreateFood();
        //food.Draw();


        //while (true)
        //{
        //    if (snake.Eat(food))
        //    {
        //        food = foodCreator.CreateFood();
        //        food.Draw();
        //        //ConsoleKeyInfo key = Console.ReadKey();
        //        //snake.HandleKey(key.Key);
        //        //ConsoleKeyInfo key = Console.ReadKey();
        //        //if (key.Key == ConsoleKey.LeftArrow)
        //        //    snake.direction = Direction.LEFT;
        //        //else if (key.Key == ConsoleKey.RightArrow)
        //        //    snake.direction = Direction.RIGHT;
        //        //else if (key.Key == ConsoleKey.DownArrow)
        //        //    snake.direction = Direction.DOWN;
        //        //else if (key.Key == ConsoleKey.UpArrow)
        //        //    snake.direction = Direction.UP;

        //    }
        //    else
        //    {
        //        snake.Move();
        //    }

        //    Thread.Sleep(100);

        //    if (Console.KeyAvailable)
        //    {
        //        ConsoleKeyInfo key = Console.ReadKey();
        //        snake.HandleKey(key.Key);
        //    }

        //    snake.Move();
        //}



        //Console.WriteLine();

        //List<int> numList = new List<int>();
        //numList.Add(0);
        //numList.Add(1);
        //numList.Add(2);
        ////muutujatele ligipääsu saamiseks on vaja teada nende järjekorranumbrit.

        //int x = numList[0];
        //int y = numList[1];
        //int z = numList[2];

        //foreach (int i in numList)
        //{
        //    Console.WriteLine(i);

        //}

        //numList.RemoveAt(0);

        //List<Point> pList = new List<Point>();
        //pList.Add(p1);
        //pList.Add(p2);

        ////Kapseldamine - kapseldamine, isoleerimine, millegi võõra sissepiiramine, et välistada selle mõju ümbritsevale keskkonnale.
        ///




        //Console.ReadLine();
        //}

        //static void Draw(Figure figure)
        //{
        //    figure.Draw();

        //}
    }

}

