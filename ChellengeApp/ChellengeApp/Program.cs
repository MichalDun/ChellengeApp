using ChellengeApp;

var employee = new Employee("Michał", "Dunajewski");
employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(1.5);
employee.AddGrade(290);
employee.AddGrade("8,3");
employee.AddGrade(5.7F);
employee.AddGrade(0x2F);
var statistics = employee.GetStatistics();

Console.WriteLine($"Avarage: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
