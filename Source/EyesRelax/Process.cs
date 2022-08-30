using System;
using System.Timers;

namespace EyesRelax
{
    public class Process
    {
        private Timer mainTimer;

        public Timer MainTimer { get { return mainTimer; } }
        
        public Process(Settings settings)
        {
            mainTimer = new Timer();
        }
        
    }
}
