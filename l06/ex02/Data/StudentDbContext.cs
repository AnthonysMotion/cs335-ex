using Microsoft.EntityFrameworkCore;
using ex02.Model;

namespace ex02.Data
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=students.sqlite");
        }
    }
}
