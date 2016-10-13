using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Average_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            const string inputFilePath = @"input.txt";
            const string outputFilePath = @"output.txt";

            string[] input = File.ReadAllLines(inputFilePath);

            List<Student> students = new List<Student>();

            int studentCount = int.Parse(input[0]);

            for (int i = 0; i < studentCount; i++)
            {
                string[] commandArgs = input[i + 1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string name = commandArgs[0];
                List<double> grades = commandArgs.Skip(1).Select(x => double.Parse(x)).ToList();

                Student student = new Student(name);
                student.Grades.AddRange(grades);
                students.Add(student);
            }

            var orderedStudents = students.Where(s => s.Grades.Average() >= 5).OrderBy(s => s.Name)
                                    .ThenByDescending(s => s.Grades.Average());

            foreach (var student in orderedStudents)
            {
                File.AppendAllText(outputFilePath, $"{student.Name} -> {student.Grades.Average():f2}" + Environment.NewLine);
            }
        }
    }

    class Student
    {
        public Student(string name)
        {
            this.Name = name;
            this.Grades = new List<double>();
        }
        public string Name { get; set; }
        public List<double> Grades { get; set; }
    }
}
