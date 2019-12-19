using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
          
            stopWatch.Start();
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedTime.TotalMilliseconds);

            stopWatch.Start();
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedTime.TotalMilliseconds);

            stopWatch.Start();
            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedTime.TotalMilliseconds);
                
        }
    }
}
