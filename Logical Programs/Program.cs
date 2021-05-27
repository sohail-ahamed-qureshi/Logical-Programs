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
                    GenerateFibonacciSeries fibonacciSeries = new GenerateFibonacciSeries();
                    fibonacciSeries.FibonacciSeries(10);
                    break;
                case 2:
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }
           


        }
    }
}
