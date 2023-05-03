using ChallengeApp;

var employee = new Employee("Michał", "Musiał");        
employee.AddGrade(5);
employee.AddGrade(6);
employee.AddGrade(7);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}"); 
Console.WriteLine($"Min: {statistics.Min}");                          
Console.WriteLine($"Max: {statistics.Max}");           
