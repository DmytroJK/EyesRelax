using System;

namespace EyesRelax
{
    public class Settings : DefaultSettings
    {
        public int WorkingTime { get; set; } //in minutes 
        public int SmallBrake { get; set; } //in minutes
        public static sbyte LongBreakCounter { get; set; } //counts long breaks
        public int LongBreak { get; set; } //in minutes
        public bool OverallWorkingTime { get; set; } //in hours & minutes
    }
}
