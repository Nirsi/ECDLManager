using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECDLManager
{
    class FormatedStudent
    {
        internal string name { get; private set; }
        internal string lastname { get; private set; }
        internal int examDuration { get; private set; }

        internal FormatedStudent(string name, string lastname, int examDuration)
        {
            this.name = name;
            this.lastname = lastname;
            this.examDuration = examDuration;
        }
    }
}
