namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenAddScore_ShouldReturnResult()
        {
            // arrange
            var employee = new Employee("Kasia", "Kowalska", 29);
            employee.AddScore(5);
            employee.AddScore(1);
            employee.AddScore(3);
            employee.AddScore(5);
            //act
            var result = employee.Result;
            //assert
            Assert.AreEqual(14, result);
        }
        [Test]
        public void WhenAddMinusScore_ShouldReturnResult()
        {
            // arrange
            var employee = new Employee("Zuzia", "Nowak", 28);
            employee.AddScore(-5);
            employee.AddScore(8);
            employee.AddScore(1);
            employee.AddScore(-5);
            //act
            var result = employee.Result;
            //assert
            Assert.AreEqual(-1, result);
        }
        [Test]
        public void WhenAddOnlyMinusScore_ShouldReturnResult()
        {
            // arrange
            var employee = new Employee("Darek", "Wiœniewski", 28);
            employee.AddScore(-5);
            employee.AddScore(-8);
            employee.AddScore(-1);
            employee.AddScore(-5);
            //act
            var result = employee.Result;
            //assert
            Assert.AreEqual(-19, result);
        }
    }
}