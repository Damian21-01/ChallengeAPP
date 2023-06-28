using ChallengeAPP;

Employee employee1 = new Employee("Adam ", "Lewandowski", 43 );
Employee employee2 = new Employee("Anna ", "Nowak", 50);
Employee employee3 = new Employee("Jan ", "Płóciennik", 20);

employee1.AddGrade(10);
employee1.AddGrade(9);
employee1.AddGrade(4);
employee1.AddGrade(8);
employee1.AddGrade(10);

employee2.AddGrade(7);
employee2.AddGrade(5);
employee2.AddGrade(6);
employee2.AddGrade(8);
employee2.AddGrade(9);

employee3.AddGrade(8);
employee3.AddGrade(6);
employee3.AddGrade(8);
employee3.AddGrade(7);
employee3.AddGrade(10);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = 0;
 
Employee employeeWithMaxResult = null;

foreach (var employee in employees )
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }    
}

Console.WriteLine("Pracownik z najwyższą liczbą ocen to: " + employeeWithMaxResult.Name + employeeWithMaxResult.Surname + ", Wiek: " + employeeWithMaxResult.Age);
Console.WriteLine("Liczba ocen wynosi: " + employeeWithMaxResult.Result);




