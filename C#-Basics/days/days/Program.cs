using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate = new DateTime(2015, 9,1);
            DateTime secDate = new DateTime(2015,12, 2);

            TimeSpan span = secDate.Subtract(firstDate);
            Console.WriteLine(span);
        }
    }
}
