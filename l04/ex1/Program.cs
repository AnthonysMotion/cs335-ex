using System.Collections.Generic;

namespace l04_ex1;

class Program
{
    static void Main(string[] args)
    {
        List<Person> _people = new List<Person>()
        {
            new Person("Bob", 35), new Person("Charlie", 40), new Person("Anthony", 20), new Person("Timmy", 12)
        };

        var oldpeople = _people.Where(p => p.Age > 30);

        Console.WriteLine("Persons older than 30:");
        foreach (var person in oldpeople)
        { 
            Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
        }
    }
}
