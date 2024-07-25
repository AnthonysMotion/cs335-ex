namespace l04_ex3;

class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>()
        {
            new Person("Alice", "Manager", 30),
            new Person("Bob", "Developer", 25),
            new Person("Charlie", "Designer", 33),
            new Person("David", "Analyst", 26),
            new Person("Eve", "Tester", 28)
        };

        var mappedpeople = people.Select(person => new { Name = person.Name, Role = person.Role });

        Console.WriteLine("Mapping of names to roles:");

        foreach (var m in mappedpeople)
        {
            Console.WriteLine("Name: {0}, Role: {1}", m.Name, m.Role);
        }
    }
}
