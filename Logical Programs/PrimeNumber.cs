using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    class PrimeNumber
    {
        public int CheckPrime(int number)
        {
            //variables
            int flag = 0;
            //check number is positive
            if(number <= 1)
            {
                Console.WriteLine($"{number} is not a prime number");
                return 0;
            }
            //check for prime
            for(int i = 2; i<= number/2; i++)
            {
                if(number % i == 0)
                {
                    Console.WriteLine($"{number} is not a prime");
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine($"{number} is a prime number");
            }
            return 0;
        }
    }
}
