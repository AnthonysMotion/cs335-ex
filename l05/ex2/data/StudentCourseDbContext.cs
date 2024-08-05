using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.data
{
    internal class StudentCourseDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=student_course.sqlite");
        }

        DbSet<Course> Courses { get; set; }
        DbSet<Student> students { get; set; }
    }
}