using System;

class MinMaxSumAverage
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            double average = 0d;
            int sum= 0;

            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num> max)
                {
                    max=num;
                }
                if (num < min )
	            {
                    min = num;
	            }
                sum += num;
            }
            average= (double)sum /count;
            Console.WriteLine("Min " + min);
            Console.WriteLine("Max "+max);
            Console.WriteLine("Sum "+ sum);
            Console.WriteLine("Avr {0:f2} ",average);


        }
    }

