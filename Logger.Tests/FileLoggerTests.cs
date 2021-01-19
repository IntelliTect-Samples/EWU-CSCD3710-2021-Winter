using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Logger.Tests
{
    [TestClass]
    public class FileLoggerTests
    {
        [TestMethod]
        public void CreateFileLogger_Success()
        {
            _ = new FileLogger("");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void LogPath_SetToNullInConstructor_ThrowArgumentNullException()
        {
            _ = new FileLogger(null!);
        }

        private const string FileLoggerLogPath = "log";

        [TestInitialize]
        public void Setup()
        {
            Cleanup();
        }

        [TestCleanup]
        public void Cleanup()
        {
            File.Delete(FileLoggerLogPath);
        }

        [TestMethod]
        public void Log_CreatesLogFileWhenNotExists_LogFileExists()
        {
            var fileLogger = new FileLogger(FileLoggerLogPath);

            fileLogger.Log(LogLevel.Error, "message");

            Assert.IsTrue(File.Exists(FileLoggerLogPath));
        }
    }
}
