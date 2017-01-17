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

        internal TimeManager(List<FormatedStudent> formatedStudents)
        {
            foreach (var fs in formatedStudents)
            {
                times.Add(new MinSecTime(fs.examDuration));
            }
            G.I.Dof.WriteInfo("Byly vygenerovány všechny časy pomocí TimeManageru");
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

        internal void KillTimer(int index, string withStatus)
        {
            times[index].Kill(withStatus);
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
