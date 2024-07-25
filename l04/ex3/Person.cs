using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l04_ex3
{
    internal class Person
    {
        public Person(string n, string r, int a) 
        {
            Name = n; Role = r; Age = a;
        }

        public string Name { get; set; }
        public string Role { get; set; }
        public int Age { get; set; }
    }
}
