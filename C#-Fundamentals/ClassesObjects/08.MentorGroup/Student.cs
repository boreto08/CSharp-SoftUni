using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MentorGroup
{
    class Student
    {
        public string Name { get; set; }
        public List<DateTime> attendance { get; set; }
        public List<string> comments { get; set; }

        public Student()
        {
            this.attendance = new List<DateTime>();
            this.comments = new List<string>();
        }
    }
}
