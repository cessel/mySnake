﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySnake
{
    class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point(1,3,'*');
            /*
            p1.x = 1;
            p1.y = 3;
            p1.sim = '*';
            */
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            /*
            p2.x = 4;
            p2.y = 5;
            p2.sim = '#';
            */
            p2.Draw();

           
            Console.ReadLine();
        }
    }
}
