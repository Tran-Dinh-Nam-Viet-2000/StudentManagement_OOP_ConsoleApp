using StudentManagement_ConsoleApp.Business;
using StudentManagement_ConsoleApp.Common;

namespace StudentManagement_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Menu-----");
            Console.WriteLine("1. Create student");
            Console.WriteLine("2. Update student information by ID");
            Console.WriteLine("3. Delete student by ID");
            Console.WriteLine("4. Search student by name");
            Console.WriteLine("5. Sort students by GPA");
            Console.WriteLine("6. Sort students by name");
            Console.WriteLine("7. Sort students by ID");
            Console.WriteLine("8. Display all student");
            Console.WriteLine("-------------------------");
            StudentManagement studentManagement = new StudentManagement();
            //Student student = new Student();
            while (true)
            {
                Console.WriteLine();
                Console.Write("-> Choose a number: ");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Console.WriteLine("---Create student information--- ");
                        studentManagement.CreateStudent();
                        break;
                    case 2:
                        Console.Write("Student Id: ");
                        int studentId = Convert.ToInt32(Console.ReadLine());
                        studentManagement.UpdateStudent(studentId);
                        break;
                    case 3:
                        Console.WriteLine("---Delete student--- ");
                        Console.Write("Student Id: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        studentManagement.Delete(deleteId);
                        break;
                    case 4:
                        Console.WriteLine("---Search student--- ");
                        string keyword = Convert.ToString(Console.ReadLine());
                        studentManagement.SearchByName(keyword);
                        studentManagement.DisplayStudent(studentManagement.SearchByName(keyword));
                        break;
                    case 5:
                        Console.WriteLine("---Sort student by GPA--- ");
                        studentManagement.DisplayStudent(studentManagement.SortByGPA());
                        break;
                    case 6:
                        Console.WriteLine("---Sort student by name--- ");
                        studentManagement.DisplayStudent(studentManagement.SortByName());
                        break;
                    case 7:
                        Console.WriteLine("---Sort student by Id--- ");
                        studentManagement.DisplayStudent(studentManagement.SortById());
                        break;
                    case 8:
                        Console.WriteLine("---Display student--- ");
                        studentManagement.DisplayStudent(studentManagement.GetListStudent());
                        break;
                }
                if (options >= 9)
                {
                    Console.WriteLine(Messages.ExitPrograms);
                    break;
                }
            }
        }
    }
}
