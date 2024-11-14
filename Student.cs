using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagementSystem
{
    public class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        private List<int> Grades { get; set; }

        public Student(string name, int id)
        {
            Name = name;
            ID = id;
            Grades = new List<int>();
        }

        public void AddGrade(int grade)
        {
            Grades.Add(grade);
            Console.WriteLine($"Grade {grade} added for student {Name}.");
        }

        public double CalculateAverageGrade()
        {
            if (Grades.Count == 0) return 0;
            double sum = 0;
            Grades.ForEach(g => sum += g);
            return sum / Grades.Count;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student: {Name} | ID: {ID}");
            Console.WriteLine($"Grades: {string.Join(", ", Grades)}");
            Console.WriteLine($"Average Grade: {CalculateAverageGrade():F2}");
        }
    }
}
