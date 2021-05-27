using System;

namespace Logical_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs");
            Console.WriteLine("Press 1. for Fibonacci Series.");
            Console.WriteLine("Press 1. for Perfect number.");
            //user input
            int selection = Convert.ToInt32(Console.ReadLine());
            //validating selection 
            while(selection < 1 || selection > 6)
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("Enter a proper selection");
                 selection = Convert.ToInt32(Console.ReadLine());
            }
            //switch case
            switch (selection)
            {
                case 1:
                    //Fibonacci Series
                    GenerateFibonacciSeries fibonacciSeries = new GenerateFibonacciSeries();
                    fibonacciSeries.FibonacciSeries(10);
                    break;
                case 2:
                    //perfect number (6, 28, 496, 8128 )
                    PerfectNumber perfect = new PerfectNumber();
                    perfect.CheckPerfectNumber(8128);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }
           


        }
    }
}
