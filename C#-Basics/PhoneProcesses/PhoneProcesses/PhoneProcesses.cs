using System;

    class PhoneProcesses
    {
        static void Main()
        {
            string startBatteryPercent = Console.ReadLine();
            startBatteryPercent = startBatteryPercent.Remove(startBatteryPercent.Length - 1);
            int startPercent = int.Parse(startBatteryPercent);
            
            int programsCount = 0;
            bool justContProgLeft = true;
            bool isPhoneOff = false;
            while (true)
            {
                string input = Console.ReadLine();
                if (string.Equals(input,"END",StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                if (!isPhoneOff)
                {
                    if (justContProgLeft)
                    {
                        string[] args = input.Split('_');
                        int neededBatteryPercent = int.Parse(args[1].Remove(args[1].Length - 1));

                        startPercent -= neededBatteryPercent;
                        if (startPercent <= 15)
                        {
                            if (startPercent <= 0)
                            {
                                isPhoneOff = true;
                                continue;
                            }
                            Console.WriteLine("Connect charger -> {0}%", startPercent);
                            programsCount--;
                            justContProgLeft = false;
                        }
                    }
                    programsCount++;
                }
                
            }
            if (startPercent <= 15 && startPercent > 0)
            {
                Console.WriteLine("Programs left -> {0}",programsCount);
            }
            else if (startPercent > 15 )
            {
                Console.WriteLine("Successful complete -> {0}%", startPercent);
            }
            else if(isPhoneOff)
            {
                Console.WriteLine("Phone Off");
            }

           
        }
    }

