using System;

namespace Logical_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs");
            GenerateFibonacciSeries fibonacciSeries = new GenerateFibonacciSeries();
            fibonacciSeries.FibonacciSeries(10);


        }
    }
}
