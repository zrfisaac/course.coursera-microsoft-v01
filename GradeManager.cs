using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagementSystem
{
    public class GradeManager
    {
        private List<Student> Students = new List<Student>();

        public void AddStudent(string name, int id)
        {
            Students.Add(new Student(name, id));
            Console.WriteLine($"Student '{name}' with ID {id} added.");
        }

        public void AssignGrade(int id, int grade)
        {
            var student = Students.Find(s => s.ID == id);
            if (student != null)
            {
                student.AddGrade(grade);
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void DisplayStudentInfo(int id)
        {
            var student = Students.Find(s => s.ID == id);
            if (student != null)
            {
                student.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void DisplayAllStudents()
        {
            Students.ForEach(student => student.DisplayInfo());
        }
    }
}
