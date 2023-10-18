using ChallengeAPP;

Console.WriteLine("Witamy w Programie ABC Do Oceny Pracowników");
Console.WriteLine("===========================================");
Console.WriteLine();

var employee = new Employee("Damian", "K");

/*try
{
    Employee emp = null;
    var name = emp.Surname;
}
catch(Exception exception)
{
    Console.WriteLine("Takiej sytuacji nie powinno być");
}
finally
{
    Console.WriteLine("Finally here");
}*/

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
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
   
}

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine(statistics.AverageLetter);



