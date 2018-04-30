using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UserLogs
{
    class User
    {
        public string Name { get; set; }
        public Dictionary<string,int> IpAndCount { get; set; }

        public User()
        {
            this.IpAndCount = new Dictionary<string, int>();
        }
    }
}
