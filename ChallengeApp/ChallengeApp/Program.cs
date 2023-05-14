using ChallengeApp;

var employee = new Employee("Michał", "Musiał");        
employee.AddGrade(9f);
employee.AddGrade("12");
employee.AddGrade(7);
employee.AddGrade(5);
var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDoWhile();
var statistics4 = employee.GetStatisticsWithWhile();

Console.WriteLine($"Average: {statistics.Average:N2}"); 
Console.WriteLine($"Min: {statistics.Min}");                          
Console.WriteLine($"Max: {statistics.Max}");           
