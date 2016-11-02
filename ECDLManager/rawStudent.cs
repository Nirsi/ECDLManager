using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECDLManager
{
    class rawStudent
    {
        internal string name { get; private set; }
        internal string lastname { get; private set; }

        internal rawStudent(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }
    }
}
