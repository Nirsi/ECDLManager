using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECDLManager
{
    class MinSecTime
    {
        internal int min { get; private set; }
        internal int sec { get; private set; }
        internal bool isCountable;


        internal MinSecTime(int min)
        {
            this.min = min;
            sec = 0;
            isCountable = true;
            
        }

        internal void CountDown()
        {
            //true for testing
            if (true)
            {
                if ((sec - 1) < 0)
                {
                    min--;
                    sec = 59;
                }
                else
                    sec--;
            }
        }
        
        internal string GetFormatedTime()
        {
            string minZero = string.Empty, secZero = string.Empty;

            if (min < 10) minZero = "0"; else minZero = string.Empty;
            if (sec < 10) secZero = "0"; else secZero = string.Empty;
            
            return minZero + min + ":"+ secZero + sec;
            
        }
    }
}
