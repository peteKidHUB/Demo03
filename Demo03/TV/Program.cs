﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV
{
    class Program
    {
        static void Main(string[] args)
        {
            tv tv = new tv();
            tv.Power = true;
            tv.Kanava = 4;
            tv.Volume = 10;
            Console.WriteLine("Toiminta leffa");
        }
    }
}
