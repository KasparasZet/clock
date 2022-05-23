using System;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in hours and mintues of analogue clock:");

            int hours = Convert.ToInt32(Console.ReadLine());
            if(hours > 12 || hours < 1)
            {
                Console.WriteLine("Wrong hour input!");
                return;
            }

            int minutes = Convert.ToInt32(Console.ReadLine());
            if (minutes >= 60 || minutes < 0)
            {
                Console.WriteLine("Wrong minute input!");
                return;
            }

            Console.WriteLine("Lesser angle in degrees between hours arrow and minutes arrow is: {0}°", calculateLesserAngle(hours, minutes));
        }

        public static double calculateLesserAngle(int hours, int minutes)
        {
            double hourMovement = (hours * 30) + (0.5 * minutes);
            double minuteMovement = minutes * 6;

            if (hours == 12 && minutes == 0)
                return 0;

            if(minutes == 0)
                return 360 - 30 * hours;

            if (minuteMovement > hourMovement)
                return minuteMovement - hourMovement;

            if(hourMovement > minuteMovement)
            {
                if(hourMovement - minuteMovement > 180)
                    return 360 - (hourMovement - minuteMovement);
                return hourMovement - minuteMovement;
            }

            return 0;
        }
    }
}
