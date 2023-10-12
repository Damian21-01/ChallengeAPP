using ChallengeAPP;

Console.WriteLine("Witamy w Programie ABC Do Oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee("Damian", "K");

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

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine(statistics.AverageLetter);



