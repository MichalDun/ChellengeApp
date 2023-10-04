using ChellengeApp;

var employee = new Employee("Michał", "Dunajewski");
employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(3);
var statistics = employee.GetStatistics();

Console.WriteLine($"Avarage: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
