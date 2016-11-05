using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECDLManager
{
    class Global
    {
        #region Singleton construction
        private static Global instance;

        private Global() { }

        public static Global I
        {
            get
            {
                if (instance == null)
                {
                    
                    instance = new Global();
                }
                return instance;
            }
        }

        #endregion

        public Dictionary<string, int> wordToNumber;
        public Dictionary<int, string> numberToWord;

        public bool debugMod = false;

        #region Translative Dictionary creation

        public void GenerateWTN()
        {
            wordToNumber = new Dictionary<string, int>()
            {
                {"zero", 0 },
                {"one", 1 },
                {"two", 2 },
                {"three", 3 },
                {"four", 4 },
                {"five", 5 },
                {"six", 6 },
                {"seven", 7 },
                {"eight", 8 },
                {"nine", 9 },
                {"ten", 10 },
                {"eleven", 11 },
                {"twelve", 12 },
                {"thriteen", 13 },
                {"fourteen", 14 },
                {"fifteen", 15 }

            };

        }

        public void GenerateNTW()
        {
            numberToWord = new Dictionary<int, string>()
            {
                {0, "zero"},
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {4, "four"},
                {5, "five"},
                {6, "six"},
                {7, "seven"},
                {8, "eight"},
                {9, "nine"},
                {10, "ten"},
                {11, "eleven"},
                {12, "twelve"},
                {13, "thriteen"},
                {14, "fourteen"},
                {15, "fifteen"}

            };
        }


        #endregion
    }
}
