using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyesRelax
{
    public class DefaultSettings : Settings
    {
        protected TimeSpan workingTimeMinutes = new TimeSpan(0, 25, 0);
        public new uint WorkingTime => (uint)workingTimeMinutes.TotalMinutes;

        protected TimeSpan smallBreakMinutes = new TimeSpan(0, 5, 0);
        public new uint SmallBreak => (uint)smallBreakMinutes.TotalMinutes;

        protected TimeSpan longBreakMinutes = new TimeSpan(0, 30, 0);
        public new uint LongBreak => (uint)longBreakMinutes.TotalMinutes;

        protected TimeSpan overallWorkingTime = new TimeSpan(9, 0, 0);
        public new uint OverallWorkingTime => (uint)overallWorkingTime.TotalHours;
        public new sbyte LongBreakCounter => 0;
        public new bool ShowOverallWorkingTime => true;

    }
}
