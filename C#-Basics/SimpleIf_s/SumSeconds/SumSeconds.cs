namespace SumSeconds
{
    using System;
    using System.Text;

    class SumSeconds
    {
        static void Main()
        {
            DateTime result = new DateTime();
            for (int i = 0; i < 3; i++)
            {
                double n = double.Parse(Console.ReadLine());
                result = result.AddSeconds(n);
            }
            Console.WriteLine("{0}:{1}",result.Minute.ToString(),result.Second.ToString().PadLeft(2,'0'));
            
        }
    }
}
