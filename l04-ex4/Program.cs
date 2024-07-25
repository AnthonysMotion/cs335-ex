namespace l04_ex4;

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>()
        {
            new Person("Eve", 30),
            new Person("David", 20),
            new Person("Bob", 35),
            new Person("Alice", 25),
            new Person("Charlie", 30)
        };

        var sortedpeople = people.OrderBy(p => p.Age).ThenBy(p => p.Name);

        Console.WriteLine("Sorted list of persons:");

        foreach (var person in sortedpeople) { 
            Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
        }
    }
}
