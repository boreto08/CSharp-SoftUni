using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsCards
{
    class Player
    {
        public string Name { get; set; }
        public HashSet<string> Cards { get; set; }

        public Player()
        {
            this.Cards = new HashSet<string>();
        }
    }
}
