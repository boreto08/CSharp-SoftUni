using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main()
        {
            var time = Console.ReadLine();
            TimeSpan setOffTime = TimeSpan.ParseExact(time, "g", CultureInfo.InvariantCulture);
            ulong steps = ulong.Parse(Console.ReadLine());
            ulong timeMakeOneStep = ulong.Parse(Console.ReadLine());
            ulong seconds = (steps * timeMakeOneStep);
            TimeSpan twentyHours = new TimeSpan(0, 24, 0, 0, 0);
            double secReady = seconds % twentyHours.TotalSeconds ;
            TimeSpan secTimeSpan = new TimeSpan(0, 0, 0, (int)secReady, 0);



            setOffTime = setOffTime + secTimeSpan;
              
            
            Console.WriteLine($"Time Arrival: {setOffTime.Hours.ToString().PadLeft(2, '0')}:{setOffTime.Minutes.ToString().PadLeft(2, '0')}:{setOffTime.Seconds.ToString().PadLeft(2, '0')}");

        }
    }
}