using System;
class LeftRightSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int left = 0;
        int right = 0;
        for (int i = 0; i < 2*n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (i < n)
            {
                left += num;
            }
            else
            {
                right += num;
            }
        }

        if (left == right)
        {
            Console.WriteLine("Yes, sum = {0}",left);
        }
        else
        {
            Console.WriteLine("No, diff = {0}",Math.Abs(left-right));
        }
    }
}

