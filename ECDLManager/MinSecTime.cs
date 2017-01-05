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
        internal bool isCountable, live = true;

        private int initialTime;


        internal MinSecTime(int min)
        {
            this.min = min;
            initialTime = min;
            if (initialTime == 0)
                sec = 10;
            else
                sec = 0;
            isCountable = true;
            
        }

        internal void CountDown()
        {
            if (isCountable)
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

        internal void Stop()
        {
            isCountable = false;
        }

        internal void Continue()
        {
            isCountable = true;
        }

        internal void Reset()
        {
            min = initialTime;
            if (initialTime == 0)
                sec = 10;
            else
                sec = 0;
        }

        internal void Kill()
        {
            live = false;
        }

        internal void SetToMinimal()
        {
            min = 0;
            sec = 1;
        }

        internal string GetFormatedTime()
        {
            if (live)
            {
                string minZero = string.Empty, secZero = string.Empty;

                if (min < 10) minZero = "0"; else minZero = string.Empty;
                if (sec < 10) secZero = "0"; else secZero = string.Empty;

                return minZero + min + ":" + secZero + sec;
            }
            else
                return "Čas vypršel";
            
        }
        
    }
}
