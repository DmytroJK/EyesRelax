using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace EyesRelaxUI
{
    internal class Timer
    {
        private static Timer aTimer;
        
        public static void Main()
        {
            aTimer = new System.Timers.Timer(1500000); //таймер на 25 хв
        }

        public static implicit operator Timer(System.Timers.Timer v)
        {
            throw new NotImplementedException();
        }
    }
}
