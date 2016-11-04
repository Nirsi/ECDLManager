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

        internal MinSecTime(int min, int sec)
        {
            this.min = min;
            this.sec = sec;
        }
    }
}
