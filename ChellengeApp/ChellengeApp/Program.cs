using ChellengeApp;
using System.ComponentModel.Design;

Employee employee1 = new Employee("Michał", "Dunajewski", 38);
Employee employee2 = new Employee("Jan", "Kowalski", 54);
Employee employee3 = new Employee("Grażyna", "Nowak", 26);

employee1.AddRating(5);
employee1.AddRating(7);
employee1.AddRating(9);
employee1.AddRating(10);
employee1.AddRating(10);

employee2.AddRating(2);
employee2.AddRating(6);
employee2.AddRating(8);
employee2.AddRating(4);
employee2.AddRating(9);

employee3.AddRating(8);
employee3.AddRating(7);
employee3.AddRating(10);
employee3.AddRating(8);
employee3.AddRating(8);

List<int> employeeResults = new List<int> { employee1.Result, employee2.Result, employee3.Result};
List<Employee> Employees = new List<Employee> { employee1, employee2, employee3 };
var maxResult = employeeResults.Max();

Console.WriteLine(" Maksymalna zdobyta ilość punktów to: " + maxResult);
Console.WriteLine(" Zdobył/a/li ją:");

foreach (var employee in Employees)
{
    if (employee.Result == maxResult)
    {
        Console.WriteLine(" " + employee.Name + " " + employee.Surname + ", wiek: " + employee.Age);
    }
}