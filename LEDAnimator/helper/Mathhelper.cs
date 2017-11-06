﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEDAnimator.helper
{
    public class Mathhelper
    {

        public static double dist(KCPoint p1, KCPoint p2)
        {
            double dist =  Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
            //Console.WriteLine(dist);
            return dist;
        }

        public static int RoundOff(int i)
        {
            return ((int)Math.Round(i / 10.0)) * 10;
        }
    }
}
