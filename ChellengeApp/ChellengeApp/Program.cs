using ChellengeApp;

var employee = new Employee("Michał", "Dunajewski");
employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(1.5);
employee.AddGrade(290);
employee.AddGrade("8,3");
employee.AddGrade(5.7F);
employee.AddGrade(0x2F);
var statistics = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithWhile();
var statistics4 = employee.GetStatisticsWithDoWhile();

Console.Write($"Avarage: {statistics.Average:N2}  ");
Console.Write($"Avarage: {statistics2.Average:N2}  ");
Console.Write($"Avarage: {statistics3.Average:N2}  ");
Console.WriteLine($"Avarage: {statistics4.Average:N2}  ");
Console.Write($"Min: {statistics.Min}  ");
Console.Write($"Min: {statistics2.Min}  ");
Console.Write($"Min: {statistics3.Min}  ");
Console.WriteLine($"Min: {statistics4.Min}  ");
Console.Write($"Max: {statistics.Max}  ");
Console.Write($"Max: {statistics2.Max}  ");
Console.Write($"Max: {statistics3.Max}  ");
Console.WriteLine($"Max: {statistics4.Max}  ");
