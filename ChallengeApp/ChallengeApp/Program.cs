using ChallengeApp;

Employee employee1 = new Employee("Darek", "Kowalski", 29);
Employee employee2 = new Employee("Kasia", "Nowak", 28);
Employee employee3 = new Employee("Marta", "Wiśniewska", 19);

employee1.AddScore(3);
employee1.AddScore(1);
employee1.AddScore(4);
employee1.AddScore(7);
employee1.AddScore(8);

employee2.AddScore(9);
employee2.AddScore(6);
employee2.AddScore(7);
employee2.AddScore(1);
employee2.AddScore(9);

employee3.AddScore(9);
employee3.AddScore(1);
employee3.AddScore(5);
employee3.AddScore(8);
employee3.AddScore(3);

 List<Employee> employess = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employess)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine("Najwyższy wynik " + maxResult + " punktów, osiągnął pracownik: " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " lat " + employeeWithMaxResult.Age);
