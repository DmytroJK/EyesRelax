using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesRelax
{
    public class DefaultSettings
    {
        protected TimeSpan workingTimeMinutes = new TimeSpan(0, 25, 0);
        protected int workingTime;
        public int WorkingTime { get => workingTime = (int)workingTimeMinutes.TotalMinutes; }

        protected TimeSpan smallBreakMinutes = new TimeSpan(0, 5, 0);
        protected int smallBreak;
        public int SmallBreak { get => smallBreak = (int)smallBreakMinutes.TotalMinutes; }

        protected TimeSpan longBreakMinutes = new TimeSpan(0, 20, 0);
        protected int longBreak;
        public int LongBreak { get => longBreak = (int)longBreakMinutes.TotalMinutes; }

        protected static int longBreakCounter;
        public static int LongBreakCounter { get => longBreakCounter = 0; }

        protected bool overallWorkingTime;
        public bool OverallWorkingTime { get => overallWorkingTime = true; }

    }
}
