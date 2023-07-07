using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using StudentManagement_ConsoleApp.Common;
using StudentManagement_ConsoleApp.Models;

namespace StudentManagement_ConsoleApp.Business
{
    public class StudentManagement
    {
        private List<Student> listStudent = new List<Student>();

        public void CreateStudent()
        {
            Student student = new Student();
            Console.Write("Id: ");
            student.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            student.Name = Console.ReadLine();
            Console.Write("Gender: ");
            student.Gender = Console.ReadLine();
            Console.Write("Math Scores: ");
            student.MathScores = Convert.ToDouble(Console.ReadLine());
            Console.Write("Physics Scores: ");
            student.PhysicsScores = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chemistry Scores: ");
            student.ChemistryScores = Convert.ToDouble(Console.ReadLine());
            Console.Write("GPA: ");
            Console.WriteLine(GradePointAverage(student));
            Console.Write("Academic Ability: ");
            Console.WriteLine(CalculateAcademicAbility(student));
            listStudent.Add(student);
            Console.WriteLine(Messages.CreateSuccessfully);
        }

        public Student FindById(int id)
        {
            Student searchStudent = null;
            if (listStudent.Count > 0 && listStudent != null)
            {
                foreach (var item in listStudent)
                {
                    if (item.Id == id)
                    {
                        searchStudent = item;
                    }
                }
            }
            return searchStudent;
        }

        public void UpdateStudent(int id)
        {
            Student student = FindById(id);
            if (student == null)
            {
                Console.WriteLine(Messages.NotFoundStudent);
            }
            else
            {
                Console.Write("Name: ");
                student.Name = Console.ReadLine();
                Console.Write("Gender: ");
                student.Gender = Console.ReadLine();
                Console.Write("Math Scores: ");
                student.MathScores = Convert.ToInt32(Console.ReadLine());
                Console.Write("Physics Scores: ");
                student.PhysicsScores = Convert.ToInt32(Console.ReadLine());
                Console.Write("Chemistry Scores: ");
                student.ChemistryScores = Convert.ToInt32(Console.ReadLine());
                Console.Write("GPA: ");
                Console.WriteLine(GradePointAverage(student));
                Console.Write("Academic Ability: ");
                Console.WriteLine(CalculateAcademicAbility(student));
                Console.WriteLine(Messages.UpdateSuccessfully);
            }
        }

        public List<Student> SearchByName(string keyword)
        {
            List<Student> listSearch = new List<Student>();
            if (keyword.Equals(""))
            {
                Console.WriteLine(Messages.NotFoundStudent);
            }
            foreach (Student item in listStudent)
            {
                if (item.Name.ToUpper().Contains(keyword.ToUpper()))
                {
                    listSearch.Add(item);
                }
            }
            return listSearch;
        }

        public List<Student> SortByGPA()
        {
            return listStudent.OrderByDescending(n => n.GPA).ToList();
        }

        public List<Student> SortByName()
        {
            return listStudent.OrderBy(n => n.Name).ToList();
        }

        public List<Student> SortById()
        {
            return listStudent.OrderBy(n => n.Id).ToList();
        }

        public void Delete(int id)
        {
            Student student = FindById(id);
            if (id != student.Id)
            {
                Console.WriteLine(Messages.NotFoundStudent);
            }
            listStudent.Remove(student);
            Console.WriteLine(Messages.DeleteSuccessfully);
        }

        //Hiển thị thông tin học sinh
        public void DisplayStudent(List<Student> students)
        {
            foreach (var item in students)
            {
                if (item.Id == 0)
                {
                    Console.WriteLine(Messages.NotFoundStudent);
                }
                else
                {
                    Console.WriteLine("Student: [" + item.Id + ", " + item.Name + ", " + item.Gender + ", " + item.Age + ", " + item.MathScores + ", " + item.PhysicsScores + ", " + item.ChemistryScores + ", " + item.GPA + ", " + item.AcademicAbility + "]");
                }
            }
        }

        public List<Student> GetListStudent()
        {
            return listStudent;
        }

        //Tính tổng trung bình 3 môn Toán Lý Hóa
        public double GradePointAverage(Student student)
        {
            student.GPA = (student.MathScores + student.ChemistryScores + student.PhysicsScores) / 3;
            return student.GPA;
        }

        //Xét học lực cho mỗi học sinh
        public string CalculateAcademicAbility(Student student)
        {
            if (GradePointAverage(student) >= 8)
            {
                student.AcademicAbility = "Excellent students";
            }
            else if (GradePointAverage(student) >= 6.5 && GradePointAverage(student) < 8)
            {
                student.AcademicAbility = "Good students";
            }
            else if (GradePointAverage(student) < 6.5 && GradePointAverage(student) >= 5)
            {
                student.AcademicAbility = "Fairly good students";
            }
            else if (GradePointAverage(student) < 5)
            {
                student.AcademicAbility = "Weak students";
            }

            return student.AcademicAbility;
        }
    }
}
