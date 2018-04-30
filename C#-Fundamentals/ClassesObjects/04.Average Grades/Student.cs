namespace _04.Average_Grades
{
    using System.Collections.Generic;
    using System.Linq;
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get; private set; }

        public Student(string name, List<double> grades)
        {
            this.Name = name;
            this.Grades = grades;
            AverageGrade = CalcAverege(Grades);
        }

        private static double CalcAverege(List<double> grades)
        {
            return grades.Average();
        }

    }
}
