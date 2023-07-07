using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_ConsoleApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }
        public double MathScores { get; set; }
        public double PhysicsScores { get; set; }
        public double ChemistryScores { get; set; }
        public double GPA { get; set; }
        public string? AcademicAbility { get; set; }

        //public override string ToString()
        //{
        //    return "Student: [" + Id + ", " + Name + ", " + Gender + ", " + Age + ", " + MathScores + ", " + PhysicsScores + ", " + ChemistryScores + ", " + GPA + ", " + AcademicAbility + "]";
        //}
    }
}
