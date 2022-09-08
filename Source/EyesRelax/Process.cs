using System;
using System.Timers;

namespace EyesRelax
{
    public class Process
    {
        private Timer mainTimer;

        public Timer MainTimer { get { return mainTimer; } }
        
        public Process(DefaultSettings defaultSettings)
        {
            mainTimer = new Timer();
        }
        
    }
}
