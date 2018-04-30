using System;
using System.Collections.Generic;

class FirefightingOrganization
{
     static Dictionary<string,int> howManyPersons = new Dictionary<string,int>();
    static void Main()
    {
        int numFirefighters = int.Parse(Console.ReadLine());
        int numberFireFighters = numFirefighters;
        howManyPersons.Add("K",0);
        howManyPersons.Add("A",0);
        howManyPersons.Add("S",0);
        int savedKids    = 0;
        int savedAlduts  = 0;
        int savedSeniors = 0;

        string input = Console.ReadLine();
        while (input != "rain")
        {
            //fill dictionary
            CountPersons(howManyPersons,input);
            while (numFirefighters > 0 && ((howManyPersons["K"] > 0 || howManyPersons["A"] > 0) || howManyPersons["S"] > 0))
	        {
	           if (howManyPersons["K"] > 0 )
	           {
		            numFirefighters--;
                    howManyPersons["K"]--;
                    savedKids++;

	           }
               else
	           {
                    if (howManyPersons["A"] > 0 )
	                {
		                numFirefighters--;
                        howManyPersons["A"]--;
                        savedAlduts++;
	                }
                    else if(howManyPersons["A"] == 0)
                    {
                        numFirefighters--;
                        howManyPersons["S"]--;
                        savedSeniors++;
                    }
                   
	           }
	        }
            //how to clear values Only !!!
            howManyPersons["S"] = 0;
            howManyPersons["A"] = 0;
            howManyPersons["K"] = 0;
            numFirefighters = numberFireFighters;
            input = Console.ReadLine();
        }
        Console.WriteLine("Kids: {0}",savedKids);
        Console.WriteLine("Adults: {0}", savedAlduts);
        Console.WriteLine("Seniors: {0}", savedSeniors);
    }

    private static void CountPersons(Dictionary<string,int> Persons,string Input)
    {
        for (int i = 0; i < Input.Length; i++)
		{
            if (Input[i] == 'K')
	        {
		        howManyPersons["K"] += 1;
	        }
            else if (Input[i] == 'A')
	        {
		        howManyPersons["A"] += 1;
	        }
            else if (Input[i] == 'S')
            {
                howManyPersons["S"] += 1;
            }
        }
    }
}

