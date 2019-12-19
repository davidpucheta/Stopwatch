using System;

namespace Stopwatch
{
    class Stopwatch
    {
        private bool _isRunning;
        public DateTime Time { get; private set; }       
        public Stopwatch()
        {
            Time = DateTime.MinValue;
            _isRunning = false;
        }

        public void Start()
        {
            if (_isRunning == false)
            {
                Time = Time == DateTime.MinValue? DateTime.Now : Time;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch already running");
            }
        }

        public void Stop()
        {
            TimeSpan timeSpan = DateTime.Now - Time;
            Console.WriteLine($"Running time(ms): {timeSpan.TotalMilliseconds}");
            _isRunning = false;
        }

    }

}

