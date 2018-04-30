using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class FileCustom
    {
        public string Name { get; set; }
        public ulong Size { get; set; }

        public FileCustom(string name , ulong size)
        {
            this.Name = name;
            this.Size = size;
        }
    }
}
