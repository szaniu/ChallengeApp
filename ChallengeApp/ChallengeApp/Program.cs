using ChallengeApp;

var employee = new Employee("Darek", "Szaniu");
employee.AddGrade("200");
employee.AddGrade(2.58);
employee.AddGrade(5.51f);
employee.AddGrade(99l);
employee.AddGrade(1);
employee.AddGrade(-1);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");