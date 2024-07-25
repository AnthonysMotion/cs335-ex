using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Student
    {
        public Student(string fn, string ln, int a, string g, string d) {
            count++;
            FirstName = fn; LastName = ln; Age = a; Gender = g; Department = d;
        }

        public static int count = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }

        public static void PrintDetails(Student s) {
            Console.WriteLine("Student {0} Details:", count);
            Console.WriteLine("First Name: {0}", s.FirstName);
            Console.WriteLine("Last Name: {0}", s.LastName);
            Console.WriteLine("Age: {0}", s.Age);
            Console.WriteLine("Gender: {0}", s.Gender);
            Console.WriteLine("Department: {0}", s.Department);
            Console.WriteLine("");
        }
    }
}