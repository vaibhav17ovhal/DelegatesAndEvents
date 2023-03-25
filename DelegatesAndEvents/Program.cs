using System;

namespace DelegatesAndEvents
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Delegates and Events");

            //DelegatesDemo demo = new DelegatesDemo();
            //demo.Run();

            MultiCastDelegates multi = new MultiCastDelegates();
            multi.Run2();
        }
    }
}
