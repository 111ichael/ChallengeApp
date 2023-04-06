using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
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