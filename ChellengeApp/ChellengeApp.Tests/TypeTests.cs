namespace ChellengeApp.Tests
{
    public class TypeTests
    {

        [Test]
        public void ValuableTest()
        {
            // arrange
            int number1 = 15;
            int number2 = 12;
            int number3 = 3;

            Assert.AreEqual(number1, number2 + number3);
        }

        [Test]
        public void ReferenceTest()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            Assert.AreNotEqual(user1, user2);
        }

        [Test]
        public void StringTest()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            Assert.AreEqual(user1.Login, user2.Login);
        }
        private User GetUser(string name)
        {
            return new User("name");
        }
    }
}
