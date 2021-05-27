using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Logical_Programs
{
    class StopWatch
    {
        public void StimulateStopWatch()
        {
            Console.WriteLine("Press Enter to start the stopwatch");
            Console.ReadLine();
            // Create a new Stopwatch.
            var stopwatch = Stopwatch.StartNew();
            Console.WriteLine("Stopwatch started...");
            Console.WriteLine("Press Enter to stop the stopwatch and show time");
            Console.ReadLine();
            // Write result.
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);
           
        }
    }
}
