<<<<<<< HEAD
namespace ChallengeApp.Tests
{
    public class EmployeeTests
=======
using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
>>>>>>> 8fa37b1049ece11c8b087b1b8df8b542e0b99344
    {
        [Test]
        public void WhenEmplyeeCollectThreeScores_ShouldCorrectResult()
        { 
            //arrange
            var employee = new Employee("Micha³", "Musia³", 27);
            employee.AddScore(5);
            employee.AddScore(4);
            employee.AddScore(-9);
            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(0, result);

        }
    }
}