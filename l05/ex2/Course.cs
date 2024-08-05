using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Course
    {
        public Course(int id, string title, int points, string department)
        {
            Id = id;
            Title = title;
            Points = points;
            Department = department;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int Points { get; set; }
        public string Department { get; set; }
    }
}
