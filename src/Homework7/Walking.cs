using System;

namespace Homework7
{
    internal class Walking
    {
        private const double walkingSpeed = 1.39;
        public DateTime dateTrainig { get; set; }
        public double WalkTime { get; set; }
        public double Calories { get; set; }
        public double Distance { get; set; }

        public static (double walkTime, double calories, double distance, DateTime startTime) Walk(int weight)
        {
            var startTime = DateTime.Now;
            Program.GetKeyByUser();
            var endTime = DateTime.Now;
            long Ticks = endTime.Ticks - startTime.Ticks;
            double walkTime = (double)Ticks / 10000000;
            double distance = walkingSpeed * walkTime;
            double calories = weight * walkingSpeed * distance / 1000 * 0.24; // translate into kilocalories
            var result = (walkTime, calories, distance, startTime);
            return result;
        }
    }
}
