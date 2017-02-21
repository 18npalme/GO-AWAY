using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = Console.BufferHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.BufferWidth = Console.LargestWindowWidth;
            Console.Write("Y");
            Thread.Sleep(750);
            Console.Write("o");
            Thread.Sleep(750);
            Console.Write("u ");
            Thread.Sleep(750);
            Console.Write("a");
            Thread.Sleep(750);
            Console.Write("r");
            Thread.Sleep(750);
            Console.Write("e ");
            Thread.Sleep(750);
            Console.Write("d");
            Thread.Sleep(750);
            Console.Write("e");
            Thread.Sleep(750);
            Console.Write("a");
            Thread.Sleep(750);
            Console.WriteLine("d");
        }
    }
}
