namespace ex2;

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("John", "Smith", 18, "M", "Computer Science");
        Student.PrintDetails(s1);

        Student s2 = new Student("Emily", "Johnson", 17, "F", "Fine Arts");
        Student.PrintDetails(s2);

        Student s3 = new Student("Michael", "Williams", 19, "M", "Mechanical Engineering");
        Student.PrintDetails(s3);
    }
}