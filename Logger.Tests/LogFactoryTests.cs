using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class LogFactoryTests
    {
        [TestMethod]
        public void CreateLogger_GivenNotConfigured_ReturnNull()
        {
            var logFactory = new LogFactory();

            Assert.IsNull(logFactory.CreateLogger(""));
        }

        [TestMethod]
        public void Create_LogFactory_Success()
        {
            _ = new LogFactory();
        }

        [TestMethod]
        public void CreateLogger_WhenConfigureFileLoggerCalled_ReturnNotNull()
        {
            var logFactory = new LogFactory();

            logFactory.ConfigureFileLogger("path");

            Assert.IsNotNull(logFactory.CreateLogger(nameof(LogFactoryTests)));
        }

        [TestMethod]
        public void CreateLogger_WhenConfigureFileLoggerNotCalled_ReturnNull()
        {
            var logFactory = new LogFactory();

            Assert.IsNull(logFactory.CreateLogger(nameof(LogFactoryTests)));
        }

        [TestMethod]
        public void CreateLogger_GivenClassNameLogFactoryTests_AreEqual()
        {
            var logFactory = new LogFactory();

            logFactory.ConfigureFileLogger("path");
            var fileLogger = logFactory.CreateLogger(nameof(LogFactoryTests));

            Assert.AreEqual(nameof(LogFactoryTests), fileLogger!.ClassName);
        }
    }
}
