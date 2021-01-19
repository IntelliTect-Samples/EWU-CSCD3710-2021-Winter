using System;
using System.IO;

namespace Logger
{
    public class FileLogger : BaseLogger
    {
        private string? _LogPath;
        public string LogPath
        {
            get { return _LogPath!; }
            set { _LogPath = value ?? throw new ArgumentNullException(); }
        }
        

        public override void Log(LogLevel logLevel, string message)
        {
            StreamWriter logStreamWriter = File.AppendText(LogPath);
            string infoLine = $"{DateTime.Now} {ClassName} {logLevel}:";

            logStreamWriter.WriteLine(infoLine);
            logStreamWriter.WriteLine(message);
        }

        public FileLogger(string logPath) => LogPath = logPath;
    }
}