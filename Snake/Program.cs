﻿using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    
    /// 1 õppetund
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();


            Point p2 = new Point(4, 5, '#');
            p2.Draw();


            Console.ReadLine();
        }


    }
}
