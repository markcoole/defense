﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenseGame
{
    class Random
    {
        private static System.Random _random = new System.Random();

        public static double NextDouble()
        {
            return _random.NextDouble();
        }
    }
}
