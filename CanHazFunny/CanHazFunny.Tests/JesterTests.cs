using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace CanHazFunny.Tests
{
    [TestClass]
    public class JesterTests
    {
       [TestMethod]
       [ExpectedException(typeof(ArgumentNullException))]
       public void Create_NullJokeService_ArgumentNullException()
       {
           IJokeService jokeService = null;
           IOutputWriter outputWriter = new ConsoleWriter();

           Jester jester = new Jester(jokeService, outputWriter);
       }

       [TestMethod]
       [ExpectedException(typeof(ArgumentNullException))]
       public void Create_NullOutputWriter_ArgumentNullException()
       {
           IJokeService jokeService = new JokeService();
           IOutputWriter outputWriter = null;

           Jester jester = new Jester(jokeService, outputWriter);
       }


        [TestMethod]
        public void TellJoke_InvokesJokeServiceWithConsoleWriter()
        {
            // Arrange
            Mock<IJokeService> mock = new (MockBehavior.Strict);
            mock.Setup(service => service.GetJoke()).Returns("a joke");

            IOutputWriter consoleWriter = new ConsoleWriter();

            Jester jester = new (mock.Object, consoleWriter);

            // Act
            jester.TellJoke();

            // Assert
            mock.VerifyAll();
        }
    }
}
