namespace StudentGradeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GradeManager manager = new GradeManager();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nStudent Grade Management System");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Assign Grade");
                Console.WriteLine("3. Display Student Info");
                Console.WriteLine("4. Display All Students");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                Console.WriteLine("");
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter student name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter student ID (integer): ");
                        int id = int.Parse(Console.ReadLine());
                        manager.AddStudent(name, id);
                        break;

                    case "2":
                        Console.Write("Enter student ID: ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("Enter grade: ");
                        int grade = int.Parse(Console.ReadLine());
                        manager.AssignGrade(id, grade);
                        break;

                    case "3":
                        Console.Write("Enter student ID: ");
                        id = int.Parse(Console.ReadLine());
                        manager.DisplayStudentInfo(id);
                        break;

                    case "4":
                        manager.DisplayAllStudents();
                        break;

                    case "5":
                        exit = true;
                        Console.WriteLine("Exiting the application.");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}
