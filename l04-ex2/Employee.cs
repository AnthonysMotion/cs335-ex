using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l04_ex2
{
    internal class Employee
    {
        public Employee(string n, string d, double s) 
        {
            Name = n; Department = d; Salary = s;
        }

        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }
}
