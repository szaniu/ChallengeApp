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
            Assert.That(statistics.Max, Is.EqualTo(5));
        }
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnMinValue()
        {
            // arrange
            var employee = new Employee("Marta", "Nowak");
            employee.AddGrade(15);
            employee.AddGrade(8);
            employee.AddGrade(1);
            employee.AddGrade(18);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.That(statistic.Min, Is.EqualTo(1));
        }
        [Test]
        public void WhenEmployeeCollectGrades_ShouldReturnAverageValue()
        {
            // arrange
            var employee = new Employee("Darek", "Wiœniewski");
            employee.AddGrade(5);
            employee.AddGrade(8);
            employee.AddGrade(1);
            employee.AddGrade(5);
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.That(statistic.Average, Is.EqualTo(4.75f));
        }
        [Test]
        public void WhenEmployeeCollectGradesInChar_ShouldReturnCorrectAverageValue()
        {
            // arrange
            var employee = new Employee("Stefan", "Burczymucha");
            employee.AddGrade("a");
            employee.AddGrade("D");
            employee.AddGrade("B");
            employee.AddGrade("A");
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.That(statistic.Average, Is.EqualTo(80));
        }
        [Test]
        public void WhenEmployeeCollectGradesInChar_ShouldReturnCorrectAverageLetter()
        {
            // arrange
            var employee = new Employee("Zdzis³aw", "Piszczyfurtka");
            employee.AddGrade("d");
            employee.AddGrade("a");
            employee.AddGrade("E");
            employee.AddGrade("B");
            //act
            var statistic = employee.GetStatistics();
            //assert
            Assert.That(statistic.AverageLetter, Is.EqualTo('B'));
        }
    }
    }