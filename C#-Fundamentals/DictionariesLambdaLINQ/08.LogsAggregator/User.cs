using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LogsAggregator
{
    class User
    {
        public string Name { get; set; }
        public int totalDuration { get; set; }
        public HashSet<string> IPs { get; set; }

        public User()
        {
            this.IPs = new HashSet<string>();
        }
    }
}
