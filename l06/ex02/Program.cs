using ex02.Data;
using ex02.Model;
using System.Security.Cryptography.X509Certificates;

namespace ex02;

class Program
{
    static void Main(string[] args)
    {
        CreateStudent(new Student { FirstName = "John", LastName = "Doe", Address = "john.doe street" });
        GetStudents();
        UpdateStudent(new Student { Id = 1, FirstName = "Jane", LastName = "Doe", Address = "jane.doe street" });
        GetStudents();
        CreateStudent(new Student { FirstName = "John", LastName = "Doe", Address = "john.doe street" });
        GetStudents();
        DeleteStudent(2);
        GetStudents();
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

    static void GetStudents()
    {
        using (var context = new StudentDbContext())
        {
            var students = context.Students.ToList();
            Console.WriteLine("Students: ");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id} : {student.FirstName} {student.LastName} ({student.Address})");
            }
        }
    }

    static void UpdateStudent(Student student)
    {
        using (var context = new StudentDbContext())
        {
            var currentStudent = context.Students.FirstOrDefault(s => s.Id == student.Id);
            if (currentStudent != null)
            {
                currentStudent.Id = student.Id;
                currentStudent.FirstName = student.FirstName;
                currentStudent.LastName = student.LastName;
                currentStudent.Address = student.Address;
            }
            context.SaveChanges();
        }
    }

    static void DeleteStudent(int id)
    {
        using (var context = new StudentDbContext())
        {
            var studentToDelete = context.Students.FirstOrDefault(e => e.Id == id);
            if (studentToDelete != null)
            {
                context.Students.Remove(studentToDelete);
            }
            Console.WriteLine("deleted");
            context.SaveChanges();
        }
    }
}
