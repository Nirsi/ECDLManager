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

        public Dictionary<string, int> wordToNumberContinue;
        public Dictionary<int, string> numberToWordContinue;

        public Dictionary<string, int> wordToNumberPause;
        public Dictionary<int, string> numberToWordPause;

        public Dictionary<string, int> wordToNumberLabel;
        public Dictionary<int, string> numberToWordLabel;

        public bool debugMod = false;

        #region Translative Dictionary creation

        //Continue 1/2
        public void GenerateWTNC()
        {
            wordToNumberContinue = new Dictionary<string, int>()
            {
                {"zeroS", 0 },
                {"oneS", 1 },
                {"twoS", 2 },
                {"threeS", 3 },
                {"fourS", 4 },
                {"fiveS", 5 },
                {"sixS", 6 },
                {"sevenS", 7 },
                {"eightS", 8 },
                {"nineS", 9 },
                {"tenS", 10 },
                {"elevenS", 11 },
                {"twelveS", 12 },
                {"thriteenS", 13 },
                {"fourteenS", 14 },
                {"fifteenS", 15 }

            };

        }
        //Continue 2/2
        public void GenerateNTWC()
        {
            numberToWordContinue = new Dictionary<int, string>()
            {
                {0, "zeroS"},
                {1, "oneS"},
                {2, "twoS"},
                {3, "threeS"},
                {4, "fourS"},
                {5, "fiveS"},
                {6, "sixS"},
                {7, "sevenS"},
                {8, "eightS"},
                {9, "nineS"},
                {10, "tenS"},
                {11, "elevenS"},
                {12, "twelveS"},
                {13, "thriteenS"},
                {14, "fourteenS"},
                {15, "fifteenS"}

            };
        }

        //Pause 1/2
        public void GenerateWTNP()
        {
            wordToNumberPause = new Dictionary<string, int>()
            {
                {"zeroP", 0 },
                {"oneP", 1 },
                {"twoP", 2 },
                {"threeP", 3 },
                {"fourP", 4 },
                {"fiveP", 5 },
                {"sixP", 6 },
                {"sevenP", 7 },
                {"eightP", 8 },
                {"nineP", 9 },
                {"tenP", 10 },
                {"elevenP", 11 },
                {"twelveP", 12 },
                {"thriteenP", 13 },
                {"fourteenP", 14 },
                {"fifteenP", 15 }

            };

        }
        //Pause 2/2
        public void GenerateNTWP()
        {
            numberToWordPause = new Dictionary<int, string>()
            {
                {0, "zeroP"},
                {1, "oneP"},
                {2, "twoP"},
                {3, "threeP"},
                {4, "fourP"},
                {5, "fiveP"},
                {6, "sixP"},
                {7, "sevenP"},
                {8, "eightP"},
                {9, "nineP"},
                {10, "tenP"},
                {11, "elevenP"},
                {12, "twelveP"},
                {13, "thriteenP"},
                {14, "fourteenP"},
                {15, "fifteenP"}

            };
        }

        //Labels 1/2
        public void GenerateWTNL()
        {
            wordToNumberLabel = new Dictionary<string, int>()
            {
                {"zeroL", 0 },
                {"oneL", 1 },
                {"twoL", 2 },
                {"threeL", 3 },
                {"fourL", 4 },
                {"fiveL", 5 },
                {"sixL", 6 },
                {"sevenL", 7 },
                {"eightL", 8 },
                {"nineL", 9 },
                {"tenL", 10 },
                {"elevenL", 11 },
                {"twelveL", 12 },
                {"thriteenL", 13 },
                {"fourteenL", 14 },
                {"fifteenL", 15 }

            };
        }
        //Labels 2/2
        public void GenerateNTWL()
        {
            numberToWordLabel = new Dictionary<int, string>()
            {
                {0, "zeroL"},
                {1, "oneL"},
                {2, "twoL"},
                {3, "threeL"},
                {4, "fourL"},
                {5, "fiveL"},
                {6, "sixL"},
                {7, "sevenL"},
                {8, "eightL"},
                {9, "nineL"},
                {10, "tenL"},
                {11, "elevenL"},
                {12, "twelveL"},
                {13, "thriteenL"},
                {14, "fourteenL"},
                {15, "fifteenL"}

            };
        }


        #endregion
    }
}
