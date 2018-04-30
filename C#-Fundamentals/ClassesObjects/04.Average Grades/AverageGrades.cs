namespace _04.Average_Grades
{
    using System;
    using System.Text;
    using System.Linq;
    using System.Collections.Generic;

    class AverageGrades
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                List<double> grades = new List<double>();
                for (int j = 1; j < input.Length; j++)
                {
                    grades.Add(double.Parse(input[j]));
                }

                Student student = new Student(name, grades);

                students.Add(student);
            }

            var orerStudents = students.Where(s => s.AverageGrade >= 5.00).OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrade);

            foreach (var student in orerStudents)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }
}
