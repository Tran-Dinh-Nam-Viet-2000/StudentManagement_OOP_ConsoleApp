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
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace StudentManagement_ConsoleApp
//{
//    public class StudentManagement
//    {
//        private List<Student> listStudent = new List<Student>();

//        public void CreatStudent()
//        {
//            Student student = new Student();
//            Console.WriteLine("---Enter student information---");
//            Console.Write("Id: ");
//            student.Id = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Name: ");
//            student.Name = Console.ReadLine();
//            Console.Write("Gender: ");
//            student.Gender = Console.ReadLine();
//            Console.Write("Math Scores: ");
//            student.MathScores = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Physics Scores: ");
//            student.PhysicsScores = Convert.ToDouble(Console.ReadLine());
//            Console.Write("Chemistry Scores: ");
//            student.ChemistryScores = Convert.ToDouble(Console.ReadLine());
//            Console.Write("GPA: ");
//            Console.WriteLine(GradePointAverage(student));
//            Console.Write("Academic Ability: ");
//            CalculateAcademicAbility(student);
//            listStudent.Add(student);
//            Console.WriteLine("--> Create successfully!!");
//        }

//        public void UpdateStudent(int id, Student student)
//        {
//            if (id != student.Id)
//            {
//                Console.WriteLine("Not found student!!");
//            }
//            else
//            {
//                Console.Write("Name: ");
//                student.Name = Console.ReadLine();
//                Console.Write("Gender: ");
//                student.Gender = Console.ReadLine();
//                Console.Write("Math Scores: ");
//                student.MathScores = Convert.ToInt32(Console.ReadLine());
//                Console.Write("Physics Scores: ");
//                student.PhysicsScores = Convert.ToInt32(Console.ReadLine());
//                Console.Write("Chemistry Scores: ");
//                student.ChemistryScores = Convert.ToInt32(Console.ReadLine());
//                Console.Write("GPA: ");
//                Console.WriteLine(GradePointAverage(student));
//                Console.Write("Academic Ability: ");
//                CalculateAcademicAbility(student);

//                Console.WriteLine("--> Update successfully!!");
//            }

//        }

//        public void Delete(int id, Student student)
//        {
//            if (id != student.Id)
//            {
//                Console.WriteLine("--> Not found student!!");
//            }
//            listStudent.Remove(student);
//            Console.WriteLine("--> Delete successfully!!");
//        }

//        public void ShowSinhVien()
//        {
//            foreach (var item in listStudent)
//            {
//                if (item.Id == 0)
//                {
//                    Console.WriteLine("--> Not found student!!");
//                }
//                else
//                {
//                    Console.WriteLine("Student: [" + item.Id + ", " + item.Name + ", " + item.Gender + ", " + item.Age + ", " + item.MathScores + ", " + item.PhysicsScores + ", " + item.ChemistryScores + ", " + item.GPA + ", " + item.AcademicAbility + "]");
//                }
//            }
//        }

//        /*
//         * Hàm trả về danh sách sinh viên hiện tại
//         */
//        public List<Student> getListSinhVien()
//        {
//            return listStudent;
//        }

//        //Hiển thị thông tin học sinh
//        public void DisplayStudent()
//        {
//            foreach (var item in listStudent)
//            {
//                if (item.Id == 0)
//                {
//                    Console.WriteLine("--> Not found student!!");
//                }
//                else
//                {
//                    Console.WriteLine("Student: [" + item.Id + ", " + item.Name + ", " + item.Gender + ", " + item.Age + ", " + item.MathScores + ", " + item.PhysicsScores + ", " + item.ChemistryScores + ", " + item.GPA + ", " + item.AcademicAbility + "]");
//                }
//            }
//        }

//        //Tính tổng trung bình 3 môn Toán Lý Hóa
//        public double GradePointAverage(Student student)
//        {
//            student.GPA = (student.MathScores + student.ChemistryScores + student.PhysicsScores) / 3;
//            return student.GPA;
//        }

//        //Xét học lực cho mỗi học sinh
//        public void CalculateAcademicAbility(Student student)
//        {
//            if (GradePointAverage(student) >= 8)
//            {
//                student.AcademicAbility = "Excellent students";
//            }
//            else if (GradePointAverage(student) >= 6.5 && GradePointAverage(student) < 8)
//            {
//                student.AcademicAbility = "Good students";
//            }
//            else if (GradePointAverage(student) < 6.5 && GradePointAverage(student) >= 5)
//            {
//                student.AcademicAbility = "Fairly good students";
//            }
//            else if (GradePointAverage(student) < 5)
//            {
//                student.AcademicAbility = "Weak students";
//            }
//        }
//    }
//}
