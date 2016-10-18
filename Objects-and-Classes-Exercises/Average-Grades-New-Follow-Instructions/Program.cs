using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_Grades_New_Follow_Instructions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int studentCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentCount; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();
                Student student = new Student(studentInfo[0]);
                student.Grades = studentInfo.Skip(1).Select(double.Parse).ToArray();
                students.Add(student);
            }

            students = students.Where(s => s.AverageGrade >= 5)
                .OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrade).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }

    class Student
    {
        public string Name;
        public double[] Grades;

        public double AverageGrade
        {
            get
            {
                return Grades.Average();
            }
        }

        public Student(string name)
        {
            this.Name = name;
        }
    }
}
