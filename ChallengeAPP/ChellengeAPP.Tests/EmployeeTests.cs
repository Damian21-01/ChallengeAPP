
using ChallengeAPP;

namespace ChellengeAPP
{
    public class EmployeeTests
    {
        [Test]
        public void WhenGetStatistiscCalled_ShouldReturnCorrectMax()
        {
            // arrange

            var employee = new Employee("Damian", "Kêdia");
            employee.AddGrade(2);
            employee.AddGrade(2);
            employee.AddGrade(6);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(6, statistics.Max);

        }
    }
}