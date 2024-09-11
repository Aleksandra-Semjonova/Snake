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
            Console.SetWindowSize( 80, 25);

            //Point p1 = new Point(1, 3, '*');
            //p1.Draw();


            //Point p2 = new Point(4, 5, '#');
            //p2.Draw();

            //образовывает рамку 
            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine =new  VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(4, 5, '*');
            p.Draw();

            Snake snake = new Snake(p, 4, Direction.RIGHT);



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
        }


    }
}
