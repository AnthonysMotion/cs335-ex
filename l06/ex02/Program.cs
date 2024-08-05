using ex02.Data;
using ex02.Model;
using System.Security.Cryptography.X509Certificates;

namespace ex02;

class Program
{
    static void Main(string[] args)
    {
        CreateStudent(new Student { FirstName = "John", LastName = "Doe", Address = "john.doe street" }); ;
    }

    static void CreateStudent(Student student)
    {
        using (var context = new StudentDbContext())
        {
            context.Students.Add(student);
            context.SaveChanges();
            Console.WriteLine($"Student {student.FirstName} {student.LastName} created.");
        }
    }
}
