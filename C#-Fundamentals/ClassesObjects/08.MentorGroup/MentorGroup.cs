using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _08.MentorGroup
{
    class MentorGroup
    {
        static void Main()
        {
            var students = new Dictionary<string, Student>();
            FillAttendances(students);
            FillComments(students);
            PrintReport(students);


        }

        public static void FillAttendances(Dictionary<string,Student> students)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of dates")
                {
                    break;
                }

                var args = input.Split();
                string name = args[0];
                var dates = args[1].Split(',');
                Student student = new Student();
                student.Name = name;
                foreach (var date in dates)
                {
                    student.attendance.Add(DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture));
                }

                if (!students.ContainsKey(name))
                {
                    students.Add(name, student);
                }
                else
                {
                    foreach (var date in students[name].attendance)
                    {
                        student.attendance.Add(date);
                    }
                    students[name] = student;
                }
            }
        }
        public static void FillComments(Dictionary<string, Student> students)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of comments")
                {
                    break;
                }
                var args = input.Split('-');
                string name = args[0];
                string comment = args[1];

                if (!students.ContainsKey(name))
                {
                    continue;
                }

                students[name].comments.Add(comment);
            }
        }
        public static void PrintReport(Dictionary<string, Student> students)
        {
            foreach (var student in students.Values)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Commnets:");
                if (student.comments.Count >= 1)
                {
                    foreach (var comment in student.comments)
                    {
                        Console.WriteLine($"- {comment}");
                    }
                }
                
                Console.WriteLine("Dates attended");
                foreach (var date in student.attendance)
                {
                    Console.WriteLine($"-- {date.ToShortDateString()}");
                }
            }
        }
    }
}
