using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal static class StateLineSt
    {
        public static int ObjectCount { get; set; }
        public static string LastActivity { get; set; }
        public static DateTime CurrentDate { get; set; }


        static StateLineSt()
        {
            ObjectCount = 0;
            LastActivity = "none";
            CurrentDate = DateTime.Now;
        }

    }
}
