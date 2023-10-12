using ChallengeAPP;

namespace TypeTest
{
    public class EmployeeTests
    {
        [Test]
        public void GetStatistics()
        {
            // arrange

            var employee = new Employee("Damian", "K");
           // employee.AddGrade('A');
            employee.AddGrade(2);
            employee.AddGrade(48);
            employee.AddGrade('A');

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(100, statistics.Max);
            Assert.AreEqual(2, statistics.Min);
            Assert.AreEqual(50, statistics.Average);

        }
    }
}



