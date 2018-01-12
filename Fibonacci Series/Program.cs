using System;

namespace Fibonacci_Series
{
    class Program
    {
        /// <summary>
        /// Entry Method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! It is a program which generates fibonacci series from 1 to 200");
            GenerateFibonacciSeries();
            Console.ReadKey();
        }

        /// <summary>
        /// Method which generates fibonacci series
        /// </summary>
        private static void GenerateFibonacciSeries()
        {
            int prev = 1,next = 1;
            Console.WriteLine(prev);
            while (next < 200)
            {
                next = prev + next;
                prev = next - prev;
                Console.WriteLine(prev);
            }
        }
    }
}
