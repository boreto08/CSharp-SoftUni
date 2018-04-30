using System;

    class Program
    {
        static void Main()
        {
            int b1 = int.Parse(Console.ReadLine());
            int b2 = int.Parse(Console.ReadLine())*2;
            int b3 = int.Parse(Console.ReadLine())*3;
            int b4 = int.Parse(Console.ReadLine())*4;
            int tableTops = int.Parse(Console.ReadLine());
            int tablesToBeMade = int.Parse(Console.ReadLine());
            int legs = b1 + b2 + b3 + b4;
            int LegsNeeded = tablesToBeMade*4;
            int tableTopsNedded = tablesToBeMade;
            int legsForTables=(legs/4);
            int tablesHeCanMake=0;
            int legsLeft = legs - LegsNeeded;
            int topsLeft = tableTops - tablesToBeMade;
            
            if (legsForTables>tableTops)
            {
                tablesHeCanMake = tableTops;
            }
            else if (legsForTables<tableTops)
	        {
		        tablesHeCanMake=legsForTables;
	        }
            else
	        {
                tablesHeCanMake = tableTops;
	        }
 
            if (tablesToBeMade>tablesHeCanMake)
            {
                Console.WriteLine("less: {0}",tablesHeCanMake-tablesToBeMade);

                if (legs >= LegsNeeded)
                {
                    LegsNeeded = 0;
                }
                else
                {
                    LegsNeeded -= legs;

                }
                if (tableTops >= tablesToBeMade)
                {
                    tableTopsNedded = 0;

                }
                else
                {
                    tableTopsNedded = tablesToBeMade - tableTops;
                    Console.WriteLine("tops needed: {0}, legs needed: {1} ", tableTopsNedded, LegsNeeded);
                }
            }
            else if(tablesToBeMade<tablesHeCanMake)
            {
                Console.WriteLine("more: {0}", tablesHeCanMake - tablesToBeMade);

                Console.WriteLine("tops left: {0}, legs left: {1} ", topsLeft, legsLeft);
                
            }
            else
            {
                Console.WriteLine("Just enough tables made: {0}", tablesHeCanMake);
            }

	        
            
           



        }
    }

