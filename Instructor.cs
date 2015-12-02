using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Assignment_3
{
    class Instructor
    {
        private string Teacher;
        private string CourseName;

        public string GetTeacherName(string Teacher)
        {
           return Teacher;
        }
        public Instructor(string Teacher, string CourseName)
        {
            this.Teacher = Teacher;
            this.CourseName = CourseName;
        }
        public void SetStudentGrade(Student Student, int Grade)
        {
            Student.SetStudentGrade(Grade);
        }
        public void PrintInstructorInfo()
        {
            string output = this.Teacher;
            output += " ";
            output += this.CourseName;
            System.Console.WriteLine(output);
            System.Console.ReadKey();
        }

        internal void PrintStudentInfo()
        {
            throw new NotImplementedException();
        }
    }
}