using ChallengeApp;

Employee employee1 = new Employee("Michał", "Musiał", 27);           
Employee employee2 = new Employee("Monika", "Kowalska", 44);
Employee employee3 = new Employee("Aleksandra", "Masłowska", 32);

employee1.AddScore(5);
employee1.AddScore(4);
employee1.AddScore(6);

employee2.AddScore(4);
employee2.AddScore(3);
employee2.AddScore(1);

employee3.AddScore(6);
employee3.AddScore(7);
employee3.AddScore(7);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3,
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if(employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("NAJWYŻEJ OCIENIANY PRACOWNIK: ");
Console.WriteLine(employeeWithMaxResult.name + " " + employeeWithMaxResult.surname);
Console.WriteLine("Lat " +employeeWithMaxResult.age);
Console.WriteLine("Wynik " + employeeWithMaxResult.Result + " punktów");