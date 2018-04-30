using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SerbianUnleashed
{
    class Event
    {
        public string Location { get; set; }
        public Dictionary<string,int> SingerMoneyDic { get; set; }

        public Event()
        {
            this.SingerMoneyDic = new Dictionary<string, int>();
        }
    }
}
