using System.Reflection.Metadata;

namespace ChellengeApp.Tests
{
    public class UserTests
    {
        [Test]
        public void WhenUserGetPoints()
        {
            var user = new User("Adam", "asdddas4223");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(2);

            var result = user.Result;

            Assert.AreEqual(13, result);
        }
        [Test]
        public void WhenUserGetAndReceivePoints()
        {
            var user = new User("Micha³", "asdddas4223");
            user.AddScore(5);
            user.SubScore(1);
            user.AddScore(2);
            var result = user.Result;

            Assert.AreEqual(6, result);
        }
        [Test]
        public void WhenUserReceivePoints()
        {
            var user = new User("Micha³", "asdddas4223");
            user.SubScore(5);
            user.SubScore(6);
            var result = user.Result;

            Assert.AreEqual(-11, result);
        }
    }
}