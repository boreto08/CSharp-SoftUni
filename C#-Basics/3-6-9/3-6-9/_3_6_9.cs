using System;

    class _3_6_9
    {
        static void Main()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int R = 0;
            switch (B)
            {
                case 3: R = A + C; break;
                case 6: R = A * C; break;
                case 9: R = A % C; break;
                default: 
                    break;
            }
            if (R % 3 == 0)
            {
                Console.WriteLine(R / 3);
                Console.WriteLine(R);
            }
            else if (R % 3 != 0)
            {
                Console.WriteLine(R % 3);
                Console.WriteLine(R);
            }
        }
    }

