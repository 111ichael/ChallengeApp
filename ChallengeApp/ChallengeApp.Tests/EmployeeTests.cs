namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void GetStatisticsShouldReturnEmployeeMaxGrade()
        {
            var employee = new Employee("Michał", "Musiał");

            employee.AddGrade(5);
            employee.AddGrade(8);
            employee.AddGrade(7);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(8, statistics.Max);
        }

        [Test]

        public void GetStatisticsShouldReturnEmployeeMinGrade()
        {
            {
                var employee = new Employee("Michał", "Musiał");

                employee.AddGrade(5);
                employee.AddGrade(8);
                employee.AddGrade(7);

                var statistics = employee.GetStatistics();

                Assert.AreEqual(5, statistics.Min);
            }
        }

        [Test]

        public void GetStatisticsShouldReturnEmployeeAverageGrade()
        {
            {
                var employee = new Employee("Michał", "Musiał");

                employee.AddGrade(5);
                employee.AddGrade(8);
                employee.AddGrade(7);

                var statistics = employee.GetStatistics();

                Assert.AreEqual(6.67, statistics.Average, 0.01);
            }

        }

    }
}
