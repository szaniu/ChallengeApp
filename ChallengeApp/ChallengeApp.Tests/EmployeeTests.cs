namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnMaxValue()
        {
            // arrange
            var employee = new Employee("Kasia", "Kowalska");
            employee.AddGrade(5);
            employee.AddGrade(1);
            employee.AddGrade(3);
            employee.AddGrade(5);
            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(5, statistics.Max);
        }
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnMinValue()
        {
            // arrange
            var employee = new Employee("Marta", "Nowak");
            employee.AddGrade(-5);
            employee.AddGrade(8);
            employee.AddGrade(1);
            employee.AddGrade(-5);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.AreEqual(-5, statistic.Min);
        }
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnAverageValue()
        {
            // arrange
            var employee = new Employee("Darek", "Wiœniewski");
            employee.AddGrade(-5);
            employee.AddGrade(8);
            employee.AddGrade(1);
            employee.AddGrade(-5);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.AreEqual(-0.25f, statistic.Average);
        }
    }
}