using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22_Stopwatch
{

    public enum StopwatchState
    {
        Started,
        Stopped
    }

    class Stopwatch
    {
        public TimeSpan LastDuration { get; private set; }
        public StopwatchState State { get; private set; }
        public DateTime StartingTime { get; private set; }

        public Stopwatch()
        {
            LastDuration = new TimeSpan(0, 0, 0);
            this.State = StopwatchState.Stopped;
        }

        public void Start()
        {
            if (State == StopwatchState.Started)
                throw new InvalidOperationException("Stopwatch already started.");

            State = StopwatchState.Started;
            StartingTime = DateTime.Now;
        }

        public void Stop()
        {
            if(State != StopwatchState.Stopped)
            {
                State = StopwatchState.Stopped;
                LastDuration = DateTime.Now - StartingTime;
            }

            Console.WriteLine("Last saved duration is: {0} hours, {1} minutes, {2} seconds", LastDuration.Hours, LastDuration.Minutes, LastDuration. Seconds);

        }


    }
}
