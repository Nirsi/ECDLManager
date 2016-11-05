using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECDLManager
{
    class TimeManager
    {
        internal List<MinSecTime> times = new List<MinSecTime>();
        List<FormatedStudent> passedStudents = new List<FormatedStudent>();

        internal TimeManager(List<FormatedStudent> passedStudents)
        {
            foreach (var fs in passedStudents)
            {
                times.Add(new MinSecTime(fs.examDuration));
            }
        }

        internal void CountDown()
        {
            foreach (var mst in times)
            {
                mst.CountDown();
            }
        }

    }
}
