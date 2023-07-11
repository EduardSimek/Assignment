﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualiseJSON
{
    interface IGlobalVariables
    {
        static string employeeName { get; set; }
        static string formattedWorkingTime { get; set; }
        static double workingTimePercentage { get; set; }
        static string formattedTotalWorkingTime { get; set; }
        static DateTime startTime { get; set; }
        static DateTime endTime { get; set; }
        static TimeSpan totalWorkingTime { get; set; }


    }
    
}
