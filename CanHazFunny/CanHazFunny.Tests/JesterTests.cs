using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;


namespace CanHazFunny.Tests
{
    [TestClass]
    public class JesterTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Jester_NullIJokeOutput_ArgumentNullException()
        {
            Jester jester = new Jester(new JokeService(), null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Jester_NullIJokeService_ArgumentNullException()
        {
            Jester jester = new Jester(null, new JokeOutput());
        }


        [TestMethod]
        public void Jester_ValidIJokeOutput_StoreValue()
        {
            IJokeService js = new JokeService();
            IJokeOutput jo = new JokeOutput();
            
            Jester jester = new Jester(js, jo);

            Assert.AreEqual(jo, jester.JokeOutput);
        }

        [TestMethod]
        public void Jester_ValidIJokeService_ArgumentNullException()
        {
           IJokeService js = new JokeService();
            IJokeOutput jo = new JokeOutput();
            
            Jester jester = new Jester(js, jo);

            Assert.AreEqual(js, jester.JokeService);
        }

        [TestMethod]
        public void TellJoke_withCuckNorrisThenWithout_Retries()
        {
            Mock<IJokeService> mock = new Mock<IJokeService>();
            mock.SetupSequence(jokeService => jokeService.GetJoke())
                .Returns("Chuck Norris Joke")
                .Returns("Knock Knock Joke");

            Jester jester = new Jester(mock.Object, new JokeOutput());
            jester.TellJoke();

            mock.Verify(jokeService => jokeService.GetJoke(), Times.Exactly(2));
        }

        [TestMethod]
        public void TellJoke_VerifyPrintJokeCalled()
        {
             Mock<IJokeService> mockJokeService = new Mock<IJokeService>();
            mockJokeService.SetupSequence(jokeService => jokeService.GetJoke()).Returns("Knock Knock Joke");

            Mock<IJokeOutput> mockJokeOutput = new Mock<IJokeOutput>();
            mockJokeOutput.SetupSequence(jokeOutput => jokeOutput.PrintJoke("Knock Knock Joke"));

            Jester jester = new Jester(mockJokeService.Object, mockJokeOutput.Object);
            jester.TellJoke();

            mockJokeOutput.VerifyAll();
        }

    }
}
