using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Homework7
{
    class Running
    {
        const double runningSpeed = 3.3;
        public DateTime dateTrainig { get; set; }
        public double RunTime { get; set; }
        public double Calories { get; set; }
        public double Distance { get; set; }

        public static (double runTime, double calories, double distance, DateTime startTime) Run(int weight)
        {
            var startTime = DateTime.Now;
            Program.GetKeyByUser();
            var endTime = DateTime.Now;
            long Ticks = endTime.Ticks - startTime.Ticks;
            double runTime = (double)Ticks / 10000000;
            double distance = runningSpeed * runTime;
            double calories = weight * runningSpeed * distance / 1000 * 0.24; // translate into kilocalories
            var result = (runTime, calories, distance, startTime);
            return result;
        }
    }
}
