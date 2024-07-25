using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l04_ex4
{
    internal class Person
    {
        public Person(string n, int a) 
        {
            Name = n; Age = a;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
