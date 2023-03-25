using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int Operation2(int a, int b);
    public class MultiCastDelegates
    {
        public int Addition(int a, int b)
        {
            Console.WriteLine();
            Console.WriteLine("Addition of " + a + " and " + b + " = " + (a + b));
            return a + b;
        }
        public int Multiplication(int a, int b)
        {
            Console.WriteLine();
            Console.WriteLine("Multiplication of " + a + " and " + b + " = " + (a * b));
            return a * b;
        }
        public void Run2()
        {
            Operation2 operation2 = Addition;
            operation2 += Multiplication;
            operation2(3, 2);
            operation2(4, 8);


        }

    }
}
