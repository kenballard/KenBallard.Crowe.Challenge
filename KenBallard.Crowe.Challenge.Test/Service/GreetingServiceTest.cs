using KenBallard.Crowe.Challenge.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KenBallard.Crowe.Challenge.Test
{
    [TestClass]
    public class GreetingServiceTest
    {
        private IGreetingService _greetingService;

        [TestInitialize]
        public void TestInitialize()
        {
            _greetingService = new GreetingService();
        }

        [TestMethod]
        public void Can_Get_Greeting()
        {
            // Arrange
            const string expected = "Hello World";

            // Act
            var actual = _greetingService.Get();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
