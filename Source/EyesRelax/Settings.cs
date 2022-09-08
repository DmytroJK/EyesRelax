using System;

namespace EyesRelax
{
    public abstract class Settings
    {
        public uint WorkingTime { get; set; } //in minutes 
        public uint SmallBreak { get; set; } //in minutes
        public sbyte LongBreakCounter { get; set; } //counts long breaks
        public uint LongBreak { get; set; } //in minutes
        public uint OverallWorkingTime { get; set; } //in hours
        public bool ShowOverallWorkingTime { get; set; } //yes or no
    }
}
