using System;

class FourFactors
{
    static void Main()
    {
        //1.	FG – Field Goals
        //2.	FGA – Field Goal Attempts
        //3.	3P – 3-Point Field Goals
        //4.	TOV – Turnovers
        //5.	ORB – Offensive Rebounds
        //6.	Opp DRB – Opponent Defensive Rebounds
        //7.	FT – Free Throws
        //8.	FTA – Free Throw Attempts
        
        //OUTPUT
        //•	eFG% {factor result}
        //•	TOV% {factor result}
        //•	ORB% {factor result}
        //•	FT% {factor result}


        uint FG = uint.Parse(Console.ReadLine());
        uint FGA = uint.Parse(Console.ReadLine());
        uint ThreeP = uint.Parse(Console.ReadLine());
        uint TOV = uint.Parse(Console.ReadLine());
        uint ORB = uint.Parse(Console.ReadLine());
        uint oppDRB = uint.Parse(Console.ReadLine());
        uint FT = uint.Parse(Console.ReadLine());
        uint FTA = uint.Parse(Console.ReadLine());

        decimal EFG = ((decimal)FG + 0.5m * (decimal)ThreeP) / (decimal)FGA;
        decimal TovPerc = (decimal)TOV / ((decimal)FGA + 0.44m * (decimal)FTA + (decimal)TOV);
        decimal OrbPerc = (decimal)ORB / (decimal)(ORB + oppDRB);
        decimal FtPerc = (decimal)FT / (decimal)FGA;
        Console.WriteLine("EFG:{0:f3}",EFG);
        Console.WriteLine("TOV:{0:f3}", TovPerc);
        Console.WriteLine("ORB:{0:f3}", OrbPerc);
        Console.WriteLine("FT:{0:f3}", FtPerc);
    }
}

