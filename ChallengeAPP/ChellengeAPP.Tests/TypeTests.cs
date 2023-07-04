using ChallengeAPP;

namespace ChellengeAPP.Tests
{
    public class TypeTests
    {
        [Test]
        public void NumberIsDifferent()
        {
            // arrange
            int number1 = 1;
            int number2 = 2;    

            // act

            // assert 
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void WhenStringAreEqual()
        {
            // arrange
            string string1 = "Damian";
            string string2 = "Damian";

            // act

            // assert 
            Assert.AreEqual(string1, string2);
        }

        [Test]
        public void GetUserShouldReturnDifferentObects()
        {
            // arrange
            var employee1 = GetEmployee("Adam");
            var employee2 = GetEmployee("Tomasz");

            // act
            

            // assert 
            Assert.AreNotEqual(employee1, employee2); 
        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
