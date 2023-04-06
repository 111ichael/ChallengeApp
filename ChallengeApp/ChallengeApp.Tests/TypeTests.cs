namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            //arrange
            var employee1 = GetEmployee("Michał", "Musiał", 27);
            var employee2 = GetEmployee("Monika", "Kowalska", 44);
            var employee3 = GetEmployee("Aleksandra", "Dygas", 32);

            //act

            //assert
            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }

        [Test]
        public void ComparsionOfTwoIntNumbers()
        {
            //arrange
            int number1 = 4;
            int number2 = 4;

            //act
            //assert
            Assert.AreEqual(number1, number2);
        }

    }

}