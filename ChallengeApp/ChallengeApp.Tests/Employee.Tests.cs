using NUnit.Framework;

namespace ChallengeApp.Tests

{
    public class EmployeeTests
    {
        [Test]
        public void GetStatisticsShouldReturnCorrectLetterMin()
        {
            var employee = new Employee();

            employee.AddGrade('A');
            employee.AddGrade('B');
            employee.AddGrade('C');
            employee.AddGrade('D');
            employee.AddGrade('E');
            
            var statistics = employee.GetStatistics();

            Assert.AreEqual(20, statistics.Min);
        }

        [Test]
        public void GetStatisticsShouldReturnCorrectLetterMax()
        {
            var employee = new Employee();

            employee.AddGrade('A');
            employee.AddGrade('B');
            employee.AddGrade('C');
            employee.AddGrade('D');
            employee.AddGrade('E');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(100, statistics.Max);    
        }

        [Test]
        public void GetStatisticsShouldReturnCorrectLetterAverage()
        {
            var employee = new Employee();

            employee.AddGrade(5);
            employee.AddGrade(10);
            employee.AddGrade(15);

            var statistics = employee.GetStatistics();

            Assert.AreEqual('E', statistics.AverageLetter);
        }

    }
}
