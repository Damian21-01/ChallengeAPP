namespace ChellengeAPP
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Adam", "Lewandowski", 43);
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(-1);
            employee.AddGrade(-1);
            employee.AddGrade(-7);

            // act
            var result = employee.Result;

            // assert 
            Assert.AreEqual(2, result);
        }
    }
}