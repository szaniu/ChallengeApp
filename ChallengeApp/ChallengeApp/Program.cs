using ChallengeApp;


Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("-------------------------------------------\n");

var employee = new Employee();
Console.WriteLine("Podaj ocenę pracownika: ");
var inputFirst = Console.ReadLine();
employee.AddGrade(inputFirst);

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");



/*var employee = new Employee("Darek", "Szaniu");
employee.AddGrade("200");
employee.AddGrade(2.58);
employee.AddGrade(5.51f);
employee.AddGrade(99L);
employee.AddGrade(1);
employee.AddGrade(1);
employee.AddGrade(-1);
employee.AddGrade('A');
var statistics = employee.GetStatistics();*/



/*Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Ocena literowa: {statistics.AverageLetter}");*/
