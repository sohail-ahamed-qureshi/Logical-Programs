﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class GenerateFibonacciSeries
    {
        public int FibonacciSeries(int range)
        {
            int fibonacci, previous_number=1, current_number = 2;
            //check if number is greater than one
            if(range <= 1)
            {
                Console.WriteLine("enter the range greater than 1.");
                return 0;
            }
            Console.Write(previous_number+" " +current_number);
            for ( int counter= 1; counter <= range; counter++)
            {
                fibonacci = previous_number + current_number;
                previous_number = current_number;
                current_number = fibonacci;
                Console.Write(" "+fibonacci);
            }
            return 0;



        }
    }
}
