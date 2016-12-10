using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECDLManager
{
    class G
    {
        #region Singleton construction
        private static G instance;

        private G() { }

        public static G I
        {
            get
            {
                if (instance == null)
                {
                    
                    instance = new G();
                }
                return instance;
            }
        }

        #endregion

        /// <summary>
        /// status bool for debug mod of application
        /// </summary>
        public bool debugMod = false;
        /// <summary>
        /// Short for default Highlighter colors of test subjects
        /// </summary>
        public bool defaultHlm = true;
        /// <summary>
        /// Instance for debug window
        /// </summary>
        public DebugOutputForm dof;
        /// <summary>
        /// Globalised instance Entry form 
        /// </summary>
        public Entry entry;
    }
}
