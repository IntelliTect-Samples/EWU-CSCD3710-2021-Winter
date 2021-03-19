using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assignment9.Tests
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        public void CanExecuteDelegate_CanExecuteReturnsFalseWhenNotAbleToExecute()
        {
            Command relay = new(() => System.Console.WriteLine("Testing"), () => false);
            Assert.IsFalse(relay.CanExecute(null));
        }

        [TestMethod]
        public void CanExecuteDelegate_CanExecuteReturnsTrueWhenAbleToExecute()
        {
            Command relay = new(() => System.Console.WriteLine("Testing"), () => true);
            Assert.IsTrue(relay.CanExecute(null));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void RelayCommand_PassInNullValues_ThrowNullArgumentException()
        {
            Command relayCommand = new(null!, null!);
        }
    }
}
