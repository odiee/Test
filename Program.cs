using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_1050_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instructors
            Instructor John = new Instructor("John", "English");
            Instructor Mike = new Instructor("Mike", "Math");

            //Jane
            Student Jane = new Student("Jane", John);
            John.SetStudentGrade(Jane, 95);
            Jane.PrintStudentInfo();

            //Joe
            Student Joe = new Student("Joe", John);
            John.SetStudentGrade(Joe, 85);
            Joe.PrintStudentInfo();

            //Mellisa
            Student Melissa = new Student("Melissa", Mike);
            Mike.SetStudentGrade(Melissa, 90);
            Mike.PrintStudentInfo();

            //Matt
            Student Matt = new Student("Matt", Mike);
            Mike.SetStudentGrade(Matt, 92);
            Matt.PrintStudentInfo();
        }
    }
}
