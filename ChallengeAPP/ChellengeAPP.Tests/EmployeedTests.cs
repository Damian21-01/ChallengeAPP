namespace ChellengeAPP
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Adam", "Lewandowski", 43);
            var employee1 = new Employee("Anna", "Nowak", 50);
            employee.AddGrade(5);
            employee.AddGrade(6);
            employee.AddGrade(-1);
            employee.AddGrade(-1);
            employee.AddGrade(-7);
            employee1.AddGrade(8);
            employee1.AddGrade(2);

            // act
            var result = employee.Result;
            var result1 = employee1.Result;
            
            // assert 
            Assert.AreEqual(2, result);
            Assert.AreEqual(10, result1);
        }
    }
}