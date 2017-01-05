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

        internal void PauseTimer(int index)
        {
            times[index].Stop();
        }

        internal void RestoreTimer(int index)
        {
            times[index].Continue();
        }

        internal void KillTimer(int index)
        {
            times[index].Kill();
        }

        internal void RestoreAll()
        {
            foreach (var mst in times)
            {
                mst.Continue();
            }
        }
        internal void ResetAll()
        {
            foreach (var mst in times)
            {
                mst.Reset();
            }
        }
        internal void EndTimer(int index)
        {
            times[index].SetToMinimal();
        }
    }
}
