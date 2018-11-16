﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Normalization
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 55;
            int y = 64;

            double newX;
            double newY;

            if (Normalization(x, y, out newX, out newY) == true)
                Console.WriteLine("Normalization {0} and {1}", newX, newY);
            else
                Console.WriteLine("The value must be b/w 1 to 100");

            Console.ReadKey();
        }

       static bool Normalization(int x, int y,out double x1,out double y1)
        {
            x1 = 0;
            y1 = 0;
            if ((x < 1) || (x > 100))
                return false;

            if ((y < 1) || (y > 100))
                return false;

            if(x>y)
            {
                x1 = x / (double)x;
                y1 = y / (double)x;
            
            }
            else
            {
                x1 = x / (double)y;
                y1 = y / (double)y;
            }
            return true;
        }
    }
}
