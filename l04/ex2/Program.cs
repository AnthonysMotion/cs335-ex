namespace l04_ex2;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee("Alice", "Sales", 55000),
            new Employee("Eve", "Sales", 65000),
            new Employee("Anthony", "Unemployed", 0),
            new Employee("Tim", "Ball boy", 20000),
            new Employee("Blue", "Sales", 20000),
        };

        var filteredemployees = employees.Where(e => e.Department == "Sales" && e.Salary > 50000);

        Console.WriteLine("Employees from the Sales department with a salary greater than $50000:");
        foreach (var employee in filteredemployees) 
        {
            Console.WriteLine("Name: {0}, Department: {1}, Salary: ${2}", employee.Name, employee.Department, employee.Salary);
        }
    }
}
