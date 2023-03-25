﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int Operation(int a, int b);
    public class DelegatesDemo
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }
        public void Run()
        {
            Operation operation = new Operation(Addition);
            Console.WriteLine(operation(2, 5));
        }
    }
}
