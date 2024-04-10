using ChallengeApp;

Console.WriteLine("Witamy w programie XYZ do oceny Pracowników");
Console.WriteLine("-------------------------------------------\n");

var employee = new Employee("Darek", "Szaniu", 'M');
employee.ToString();

Console.WriteLine("Podaj ocenę pracownika: ");
var inputFirst = Console.ReadLine();
if (inputFirst == "q")
{
    Console.WriteLine("Zainicjowano opuszczenie programu bez wprowadzania oceny!");
    return;
}
employee.AddGrade(inputFirst);

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched:  {e.Message}");
    }
}

var statistics = employee.GetStatistics();
Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");