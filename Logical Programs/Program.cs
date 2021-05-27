using System;

namespace Logical_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs");
            Console.WriteLine("Press 1. for Fibonacci Series.");
            Console.WriteLine("Press 2. for Perfect number.");
            Console.WriteLine("Press 3. for Prime number.");
            Console.WriteLine("Press 4. for Reverse number.");
            Console.WriteLine("Press 5. for Stop watch number.");
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
                case 3:
                    //prime number (2,3,5,7,11... )
                    PrimeNumber prime = new PrimeNumber();
                    prime.CheckPrime(23);
                    break;
                case 4:
                    ////Reverse a number
                    ReverseNumebr reverse = new ReverseNumebr();
                    reverse.DoReverse(123);
                    break;
                case 5:
                    ////prime number (2,3,5,7,11... )
                    //PrimeNumber prime = new PrimeNumber();
                    //prime.CheckPrime(23);
                    //break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}
