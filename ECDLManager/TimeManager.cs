using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECDLManager
{
    class TimeManager
    {
        List<MinSecTime> times = new List<MinSecTime>();
        List<FormatedStudent> passedStudents = new List<FormatedStudent>();

        internal TimeManager(List<FormatedStudent> passedStudents)
        {
            foreach (var fs in passedStudents)
            {
                times.Add(new MinSecTime());
            }
        }
    }
}
