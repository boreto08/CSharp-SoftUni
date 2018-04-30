using System;


class Program
{
    static void Main()
    {
        //Arsenal, Chelsea, Manchester City, Manchester United, Liverpool, Everton, Southampton and Tottenham.
        decimal payForMatch = decimal.Parse(Console.ReadLine());
        string input=Console.ReadLine();

            int ArsenalPoints= 0;
            int ChelseaPoints= 0;
            int ManchesterCityPoints= 0;
            int ManchesterUnitedPoints= 0;
            int LiverpoolPoints= 0;
            int EvertonPoints= 0;
            int SouthamptonPoints= 0;
            int TottenhamPoints= 0;
        int matchCount=0;
        
        while (input != "End of the league.")
	    {
             
	         string[] matchInfo=input.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
             string homeTeam=matchInfo[0];
             string result= matchInfo[1];
             string awayTeam=matchInfo[2];
            
            

            switch (homeTeam)
	        {
                case "Arsenal":
                    if (result == "1")
	                {
		                ArsenalPoints+=3;
	                }
                    else if (result == "X")
	                {
                        ArsenalPoints+=1;
	                }
                    break;
                     case "Chelsea":
                    if (result == "1")
	                {
		                ChelseaPoints+=3;
	                }
                    else if (result == "X")
	                {
                        ChelseaPoints+=1;
	                }
                    break;
                     case " ManchesterCity":
                    if (result == "1")
	                {
		                ManchesterCityPoints+=3;
	                }
                    else if (result == "X")
	                {
                        ManchesterCityPoints+=1;
	                }
                    break;
                     case "ManchesterUnited":
                    if (result == "1")
	                {
		                ManchesterUnitedPoints+=3;
	                }
                    else if (result == "X")
	                {
                        ManchesterUnitedPoints+=1;
	                }
                    break;
                     case "Liverpool":
                    if (result == "1")
	                {
		                LiverpoolPoints+=3;
	                }
                    else if (result == "X")
	                {
                       LiverpoolPoints+=1;
	                }
                    break;
                    case "Everton":
                    if (result == "1")
	                {
		                EvertonPoints+=3;
	                }
                    else if (result == "X")
	                {
                       EvertonPoints+=1;
	                }
                    break;
                    case "Southampton":
                    if (result == "1")
	                {
		                SouthamptonPoints+=3;
	                }
                    else if (result == "X")
	                {
                       SouthamptonPoints+=1;
	                }
                    break;case "Tottenham":
                    if (result == "1")
	                {
		               TottenhamPoints+=3;
	                }
                    else if (result == "X")
	                {
                       TottenhamPoints+=1;
	                }
                    break;
	        }
            switch (awayTeam)
	        {
                case "Arsenal":
                    if (result == "2")
	                {
		                ArsenalPoints+=3;
	                }
                    else if (result == "X")
	                {
                        ArsenalPoints+=1;
	                }
                    break;
                case "Chelsea":
                    if (result == "2")
	                {
		                ChelseaPoints+=3;
	                }
                    else if (result == "X")
	                {
                        ChelseaPoints+=1;
	                }
                    break;
                case "ManchesterCity":
                    if (result == "2")
	                {
		                ManchesterCityPoints+=3;
	                }
                    else if (result == "X")
	                {
                        ManchesterCityPoints+=1;
	                }
                    break;
                case "ManchesterUnited":
                    if (result == "2")
	                {
		                ManchesterUnitedPoints+=3;
	                }
                    else if (result == "X")
	                {
                        ManchesterUnitedPoints+=1;
	                }
                    break;
                     case "Liverpool":
                    if (result == "2")
	                {
		                LiverpoolPoints+=3;
	                }
                    else if (result == "X")
	                {
                       LiverpoolPoints+=1;
	                }
                    break;
                    case "Everton":
                    if (result == "2")
	                {
		                EvertonPoints+=3;
	                }
                    else if (result == "X")
	                {
                       EvertonPoints+=1;
	                }
                    break;
                    case "Southampton":
                    if (result == "2")
	                {
		                SouthamptonPoints+=3;
	                }
                    else if (result == "X")
	                {
                       SouthamptonPoints+=1;
	                }
                    break;case "Tottenham":
                    if (result == "2")
	                {
		               TottenhamPoints+=3;
	                }
                    else if(result == "X")
	                {
                       TottenhamPoints+=1;
	                }
                    break;
	        }
            matchCount++;
            input = Console.ReadLine();
	    }
        decimal sum = (matchCount * payForMatch) * 1.94m;
        Console.WriteLine("{0:f2}lv.", sum);
        Console.WriteLine("Arsenal - {0} points.", ArsenalPoints);
        Console.WriteLine("Chelsea - {0} points.", ChelseaPoints);
        Console.WriteLine("Everton - {0} points.", EvertonPoints);
        Console.WriteLine("Liverpool - {0} points.", LiverpoolPoints);
        Console.WriteLine("Manchester City - {0} points.", ManchesterCityPoints);
        Console.WriteLine("Manchester United - {0} points.", ManchesterUnitedPoints);
        Console.WriteLine("Southampton - {0} points.", SouthamptonPoints);
        Console.WriteLine("Tottenham - {0} points.", TottenhamPoints);
    }
}

