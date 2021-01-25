using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace CanHazFunny.Tests
{
    [TestClass]
    public class JokeServiceTests
    {
        [TestMethod]
        public void JokeService_NullIJokeOutput_ArgumentNullException()
        {
            IJokeService js = new JokeService();
            var res = js.GetJoke();

            Assert.IsInstanceOfType(res, typeof(string));
        }

    }
}
