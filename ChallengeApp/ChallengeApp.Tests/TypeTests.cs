namespace ChallengeApp.Tests
{
    public class TypeTest
    {
        [Test]
        public void GetTwoStringShouldTheSameValue()
        {
            // arrange
            var employee1 = GetEmployee("Darek", "sjdhryu", 69);
            var employee2 = GetEmployee("Darek", "dkdk8", 26);

            // assert
            Assert.AreEqual(employee1.Name, employee2.Name);
        }
        [Test]
        public void GetTwoDoubleNumbersShouldTheDiferentValue()
        {
            // arrange
            double number1 = 1.51;
            double number2 = 2.80;

            // assert
            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void GetTwoNumbersShouldTheSameValue()
        {
            // arrange
            var employee1 = GetEmployee("Zuzia", "sjdhryu", 26);
            var employee2 = GetEmployee("Kasia", "dkdk8", 26);

            // assert
            Assert.AreEqual(employee1.Age, employee2.Age);
        }

        [Test]
        public void GetEmployeeShouldReturneDifferentObject()
        {
            // arrange
            var employee1 = GetEmployee("Darek", "ldsoihw67asnd", 25);
            var employee2 = GetEmployee("Marek", "dwdfw7asnd", 46);

            // assert
            Assert.AreNotEqual(employee1, employee2);
        }
        private Employee GetEmployee(string login, string password, int age)
        {
            return new Employee(login, password, age);
        }
    }
}