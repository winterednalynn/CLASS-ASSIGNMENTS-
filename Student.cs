using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp;

namespace ClassLecture5
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public double CSIGrade;
        public double GenEdGrade;

        public Student(string firstName, string lastName, double cSIGrade, double genEdGrade)
        {
            FirstName = firstName;
            LastName = lastName;
            CSIGrade = cSIGrade;
            GenEdGrade = genEdGrade;
        }
        //CREATING SECOND CONSTRUCTOR - 
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            CSIGrade = -1; 
            GenEdGrade=
        }
    }
 
}
