using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECDLManager
{
    class Global
    {
        private static Global instance;

        private Global() { }

        public static Global I
        {
            get
            {
                if (instance == null)
                    instance = new Global();
                return instance;
            }
        }

        public bool debugMod = false;
    }
}
