using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorrentPirate
{
    class Program
    {
        static void Main()
        {
            int allMB = int.Parse(Console.ReadLine());
            int moviePrice = int.Parse(Console.ReadLine());
            int wifeCostPerHour = int.Parse(Console.ReadLine());
            int speed= 2;
            int movieSize = 1500;

            decimal hoursInMall = (allMB / 2) / 60 / 60;
            decimal priceForDownload = (decimal)hoursInMall * (decimal)wifeCostPerHour;
            decimal movies = allMB / movieSize;
            decimal cinemaPrice = movies * moviePrice;
            if (priceForDownload<cinemaPrice)
            {
                Console.WriteLine("mall -> {0:f2}lv",priceForDownload);
            }
            else
            {
                Console.WriteLine("cinema -> {0:f2}lv", cinemaPrice);
            }

        }
    }
}
