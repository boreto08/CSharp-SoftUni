using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class EnduranceRally
    {
        static void Main()
        {
            var driversArgs = Console.ReadLine().Split();
            var fuelZones = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var checkPointIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> validCheckPointIndexes = new List<int>();

            foreach (var checkPoint in checkPointIndexes.Where( i => i >= 0 && i < fuelZones.Length))
            {
                validCheckPointIndexes.Add(checkPoint);
            }


            foreach (var driver in driversArgs)
            {
                double startingFuel = driver[0];
                double currentFuel = startingFuel;
                int movedPos = 0;

                for (int i = 0; i < fuelZones.Length; i++)
                {
                    if (validCheckPointIndexes.Contains(i))
                    {
                        currentFuel += fuelZones[i];
                        movedPos++;
                    }
                    else
                    {
                        currentFuel -= fuelZones[i];

                        if (currentFuel <= 0)
                        {
                            //if (currentFuel == 0)
                            //{
                            //    movedPos++;
                            //}
                            Console.WriteLine($"{driver} - reached {movedPos}");

                            break;
                        }
                        movedPos++;
                    }
                }

                if (currentFuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {currentFuel:f2}");
                }
            }

        }
    }
}
