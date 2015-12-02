using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Assignment_3
{
    class Student
    {
        private string StudentName;
        private int Grade;
        private Instructor Teacher;

        public Student(string StudentName, Instructor Teacher)
        {
            this.StudentName = StudentName;
            this.Teacher = Teacher;
            Grade = 0;
        }
        public void SetStudentGrade(int grade)
        {
            this.Grade = grade;
        }
        public void PrintStudentInfo()
        {
            string output = this.StudentName;
            output += " ";
            output += this.Grade;
            output += " ";
            output += this.Teacher;
            System.Console.WriteLine(output);
            System.Console.ReadKey();
        }
    }
}
