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