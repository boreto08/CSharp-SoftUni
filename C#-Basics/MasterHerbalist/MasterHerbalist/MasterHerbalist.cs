using System;
using System.Text;
    class MasterHerbalist
    {
        static void Main()
        {
            int dailyExpenses = int.Parse(Console.ReadLine());
            int money = 0;
            int days = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Season Over")
                {
                    break;
                }
                days++;
                string[] arrInput = input.Split();
                int  hours  = int.Parse(arrInput[0]);
                string path = arrInput[1];
                int price = int.Parse(arrInput[2]);
                int collectedHerbs = 0;
                if (hours <= path.Length)
                {
                    for (int i = 0; i < hours; i++)
                    {
                        if (path[i] == 'H')
                        {
                            collectedHerbs++;
                        }
                    }
                }
                else if (hours > path.Length)
                {
                    
                    int howLonger = hours- path.Length;
                    int count = 0;
                    StringBuilder extraPath = new StringBuilder();
                    while (count != howLonger)
	                {
                        
	                      for (int ch = 0; ch < path.Length; ch++)
                            {
                                
                                if (count == howLonger)
                                {
                                    break;
                                }
                                count++;
                                extraPath = extraPath.Append(path[ch]);
                                
                            }
	                }
                   
                    string longerPath = path + extraPath.ToString();
                    for (int i = 0; i < hours; i++)
                    {
                        if (longerPath[i] == 'H')
                        {
                            collectedHerbs++;
                        }
                    }
                }
                money += collectedHerbs* price;
                
            }
            decimal averageWinnings = (decimal)money / (decimal)days;
            if (averageWinnings >= dailyExpenses)
	        {
		        Console.WriteLine("Times are good. Extra money per day: {0:f2}.",averageWinnings - (decimal)dailyExpenses);
	        }
            else
	        {
                Console.WriteLine("We are in the red. Money needed: {0}.",(decimal)dailyExpenses*days - money);
	        }
        }
    }

