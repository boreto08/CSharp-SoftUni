using System;

    class Program
    {
        static void Main()
        {
            //Men: BMR = 66.5 + (13.75 x weight in kg) + (5.003 x height in cm) – (6.755 x age in years)
            //Women: BMR = 655 + (9.563 x weight in kg) + (1.850 x height in cm) – (4.676 x age in years)
            //1.	W – weight in pounds (lbs.)
            //2.	H – height in inches
            //3.	A – age
            //4.	G – gender
            //5.	E – workouts per week

            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            char g = char.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            decimal BMR = 0;
            decimal DCI=0;

            decimal kg=w/2.2m;
            decimal heightInCm = h * 2.54m;

            if (g=='m')
            {
                BMR= 66.5m+(13.75m *kg)+(5.003m * heightInCm)- (6.755m * a);
            }
            else
            {
                BMR = 655 + (9.563m * kg) + (1.850m * heightInCm) - (4.676m * a);
            }

            if (e <= 0  )
            {
                DCI=BMR*1.2m;
            }
            else if (e == 1 || e == 2 || e == 3 )
            {
                DCI = BMR * 1.375m;
            }
            else if (e == 4 || e == 5 || e == 6 )
            {
                DCI = BMR * 1.55m;
            }
            else if (e > 6 && e <= 9)
	        {
		        DCI = BMR * 1.725m;
	        }
            else if(e > 9)
	        {
                DCI = BMR * 1.9m;
	        }
            Console.WriteLine(Math.Floor(DCI));



            
        }
    }

