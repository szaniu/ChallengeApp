using ChallengeApp;

var employee = new Employee("Darek", "Szaniu");
employee.AddGrade(2);
employee.AddGrade(5);
employee.AddGrade(1);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");